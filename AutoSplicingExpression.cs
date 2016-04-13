using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace AutoSplicing 
{
    public class AutoSplicingExpression
    {
        private const string COL_PROP_NAME = "propName";

        private const string COL_PROP_VALUE = "propValue";

        private const string COL_PORP_TYPE = "propType";

        private const string COL_EXPRESSION_METHOD = "ExpressionMethod";
        
        public enum MethodType
        {
            Contains = 0,
            Equal = 1,
            GreaterThanOrEqual = 2,
            LessThanOrEqual = 3,
            GreaterThan = 4,
            LessThan = 5
        }
        
        public static DataTable GetDtCondition()
        {
            DataTable result = new DataTable();
            result.Columns.Add(COL_PROP_NAME);
            result.Columns.Add(COL_PROP_VALUE);
            result.Columns.Add(COL_PORP_TYPE);
            result.Columns.Add(COL_EXPRESSION_METHOD);
            return result;
        }

        public static Expression GetExpression(ParameterExpression param, string propName, object propValue, Type classType, Type propType, MethodType methodType = MethodType.Equal)
        {
            Expression prop = Expression.Property(param, classType.GetProperty(propName));
            Expression value = Expression.Constant(propValue, propType);
            switch (methodType)
            {
                case MethodType.Contains:
                    return Expression.Call(prop, propType.GetMethod("Contains", new Type[] { propType }), value);
                case MethodType.Equal:
                    return Expression.Equal(prop, value);
                case MethodType.GreaterThan:
                    return Expression.GreaterThan(prop, value);
                case MethodType.GreaterThanOrEqual:
                    return Expression.GreaterThanOrEqual(prop, value);
                case MethodType.LessThan:
                    return Expression.LessThan(prop, value);
                case MethodType.LessThanOrEqual:
                    return Expression.LessThanOrEqual(prop, value);
                default:
                    return null;
            }
        }
        
        public static DataTable GetDtCondition()
        {
            DataTable result = new DataTable();
            result.Columns.Add(COL_PROP_NAME);
            result.Columns.Add(COL_PROP_VALUE);
            result.Columns.Add(COL_PORP_TYPE);
            result.Columns.Add(COL_EXPRESSION_METHOD);
            return result;
        }

        public static Expression GetExpression(ParameterExpression param, string propName, object propValue, Type classType, Type propType, MethodType methodType = MethodType.Equal)
        {
            Expression prop = Expression.Property(param, classType.GetProperty(propName));
            Expression value = Expression.Constant(propValue, propType);
            switch (methodType)
            {
                case MethodType.Contains:
                    return Expression.Call(prop, propType.GetMethod("Contains", new Type[] { propType }), value);
                case MethodType.Equal:
                    return Expression.Equal(prop, value);
                case MethodType.GreaterThan:
                    return Expression.GreaterThan(prop, value);
                case MethodType.GreaterThanOrEqual:
                    return Expression.GreaterThanOrEqual(prop, value);
                case MethodType.LessThan:
                    return Expression.LessThan(prop, value);
                case MethodType.LessThanOrEqual:
                    return Expression.LessThanOrEqual(prop, value);
                default:
                    return null;
            }
            
        }
    }
}
