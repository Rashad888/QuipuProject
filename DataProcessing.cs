using HtmlAgilityPack;
using System.Linq;

namespace Quipu
{
	class DataProcessing
	{
		public int CalculateTagCount(string html, string tag)
		{
			HtmlDocument document = new HtmlDocument();
			document.LoadHtml(html);
			int countTag = document.DocumentNode.Descendants(tag).Count();
			return countTag;
		}
	}
}