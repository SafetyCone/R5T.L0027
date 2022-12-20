using System;


namespace R5T.L0027
{
	public class StringAnalysisOperator : IStringAnalysisOperator
	{
		#region Infrastructure

	    public static IStringAnalysisOperator Instance { get; } = new StringAnalysisOperator();

	    private StringAnalysisOperator()
	    {
        }

	    #endregion
	}
}