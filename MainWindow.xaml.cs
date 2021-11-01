using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Quipu
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			urlBox.ItemsSource = urlProcess.ReadUrl(@"urlList.txt");
		}
		UrlProcessing urlProcess = new UrlProcessing();
		DataProcessing dataProcess = new DataProcessing();
		List<GridResult> gridResults;
		CancellationTokenSource cancellationToken = null;

		private async void startBtn_Click(object sender, RoutedEventArgs e)
		{
			gridResults = new List<GridResult>();
			datagrid.ItemsSource = null;
			datagrid.Items.Refresh();
			cancelBtn.IsEnabled = true;
			cancellationToken = new CancellationTokenSource();
			var token = cancellationToken.Token;
			try
			{
				procescLbl.Content = "Calculating...";
				await Task.Run(() =>
				{
					MetricCalculate(token);
				});
				datagrid.ItemsSource = gridResults;
				int max = datagrid.ItemsSource.Cast<GridResult>().Max(x => x.tagCount);
				var res = from results in datagrid.ItemsSource.Cast<GridResult>()
						  where results.tagCount == max
						  select results.url;
				MessageBox.Show($"Максимальное число тегов {max} по URL: {res.First()}");
			}
			catch (OperationCanceledException)
			{
				MessageBox.Show("Something went wrong :(");
			}
			finally
			{
				cancellationToken.Dispose();
			}
		}

		void MetricCalculate(CancellationToken token)
		{
			for (int i = 0; i < urlBox.Items.Count; i++)
			{
				string htmltxt = urlProcess.GetContent(urlBox.Items[i].ToString());
				int numTag = dataProcess.CalculateTagCount(htmltxt, "a");
				gridResults.Add(new GridResult { url = urlBox.Items[i].ToString(), tagCount = numTag });

				if (token.IsCancellationRequested)
				{
					procescLbl.Dispatcher.Invoke(() => { procescLbl.Content = "Calculation is canceled"; });
					return;
				}
			}
			procescLbl.Dispatcher.Invoke(() => { procescLbl.Content = "Calculation is done"; });
		}

		private void cancelBtn_Click(object sender, RoutedEventArgs e)
		{
			cancelBtn.IsEnabled = false;
			cancellationToken.Cancel();
		}

		private void urlBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			htmlTxt.Text = string.Empty;
			htmlTxt.Text = urlProcess.GetContent(urlBox.SelectedItem.ToString());
		}
	}
}