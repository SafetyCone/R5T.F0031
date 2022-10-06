using System;

using Microsoft.AspNetCore.Html;

using Markdig;

using R5T.T0132;


namespace R5T.F0031.F001
{
	[FunctionalityMarker]
	public partial interface IMarkdownOperator : IFunctionalityMarker
	{
		public HtmlString ToHtml(string markdown)
        {
			var html = F0031.Instances.MarkdownOperator.ToHtml(markdown);

			var output = F0025.Instances.HtmlOperator.ToHtmlString(html);
			return output;
        }

		public HtmlString ToHtml(
			string markdown,
			Action<MarkdownPipelineBuilder> builderAction)
		{
			var html = F0031.Instances.MarkdownOperator.ToHtml(
				markdown,
				builderAction);

			var output = F0025.Instances.HtmlOperator.ToHtmlString(html);
			return output;
		}
	}
}