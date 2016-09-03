using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{
    /// <summary>
    /// 校验规则的定义接口
    /// </summary>
    public interface IRule
    {
        /// <summary>
        /// 校验规则的类型名称
        /// </summary>
        string RuleType { get; }
        /// <summary>
        /// 校验规则的编号，用于外部拓展
        /// </summary>
        int RuleId { get; set; }

    }

    /// <summary>
    /// 实现校验的接口
    /// </summary>
    public interface IVerify
    {
        /// <summary>
        /// 校验断言
        /// </summary>
        /// <typeparam name="T">要校验的对象的类型</typeparam>
        /// <param name="verifyobjs">要校验的对象集合，一般不少于2个对象</param>
        /// <param name="rule">校验规则的编号</param>
        /// <returns>Boolean</returns>
        bool DoVerify<T>(IList<T> verifyobjs, IRule rule);


    }

    public abstract class VerifyBaseClass : IVerify
    {
        public abstract bool DoVerify<T>(IList<T> verifyobjs, IRule rule);

        public abstract void DoPostAction(Action p);
     
        public bool Verify<T>(IList<T> verifyobjs, IRule rule, Action p)
        {
            bool result = DoVerify<T>(verifyobjs, rule);
            DoPostAction(p);
            return result;
        }
    }
}
