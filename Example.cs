using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace AutoSplicing
{
    public class Example
    {
        public void test()
    		{
    			AutoSplicingExpression ex = new AutoSplicingExpression();
    			DataTable dtCondition = ex.GetDtCondition();
    			ex.AddDtConditionRow(dtCondition, "attribute_1", false, typeof(bool?), MethodType.Equal);
    			ex.AddDtConditionRow(dtCondition, "attribute_2", 0, typeof(int), MethodType.Equal); 
    			ex.AddDtConditionRow(dtCondition, "attribute_3", ""); 
    			var condition = GetSearchCondition<T>(dtCondition);
    			list.where(condition.Compile();
    		}
    }
}
