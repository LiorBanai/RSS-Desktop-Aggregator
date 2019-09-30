using System;
using System.Linq.Expressions;

namespace Aggregator.Util
{
    /// <summary>
    /// this class solves the magic string code
    /// </summary>
    public static class Reflection
    {
        /// <summary>
        /// this method return a property's name
        /// so we won't need to write code as follow
        ///  ddlState.DataSource = stateList;
        ///  ddlState.DataTextValue = "Name";
        ///  ddlState.DataFieldValue = "Code";
        ///  ddlState.DataBind();
        /// which uses hard coded strings (magic String)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static string GetPropertyName<T, S>(Expression<Func<T, S>> expression)
        {
            MemberExpression memberExpression = (MemberExpression)expression.Body;
            return memberExpression.Member.Name;
        }


    }
}
