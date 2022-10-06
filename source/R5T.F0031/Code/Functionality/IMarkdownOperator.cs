using System;
using System.Extensions;

using Markdig;

using R5T.T0132;


namespace R5T.F0031
{
	[FunctionalityMarker]
	public partial interface IMarkdownOperator : IFunctionalityMarker
	{
		public string ToHtml(string markdown)
        {
			var output = Markdown.ToHtml(markdown);
			return output;
        }

		public string ToHtml(
			string markdown,
			MarkdownPipeline pipeline)
        {
			var output = Markdown.ToHtml(
				markdown,
				pipeline);

			return output;
        }

		public string ToHtml(
			string markdown,
			Action<MarkdownPipelineBuilder> builderAction)
        {
			var pipeline = new MarkdownPipelineBuilder()
				.Modify(builderAction)
				.Build();

			var output = this.ToHtml(
				markdown,
				pipeline);

			return output;
        }
	}
}