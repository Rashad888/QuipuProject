using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Quipu
{
	class UrlProcessing
	{
		public List<string> ReadUrl(string path)
		{
			List<string> links = new List<string>();

			using (var reader = new StreamReader(path)) 
			{
				string line;
				while ((line = reader.ReadLine()) != null) 
				{ 
					links.Add(line);
				}
			}
			return links;
		}

		public string GetContent(string link)
		{
			string result;
			HttpClient client = new HttpClient();
			using (HttpResponseMessage response = client.GetAsync(link).Result)
			{
				using (HttpContent content = response.Content)
				{
					result = content.ReadAsStringAsync().Result;
				}
			}
			return result;
		}
	}
}
