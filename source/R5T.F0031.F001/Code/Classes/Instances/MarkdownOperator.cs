using System;


namespace R5T.F0031.F001
{
	public class MarkdownOperator : IMarkdownOperator
	{
		#region Infrastructure

	    public static MarkdownOperator Instance { get; } = new();

	    private MarkdownOperator()
	    {
        }

	    #endregion
	}
}