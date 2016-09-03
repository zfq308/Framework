using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{

    /// <summary>
    /// 执行动作参数类的接口定义
    /// </summary>
    public partial interface IDoActionArgument
    {

    }

    /// <summary>
    /// 执行动作的接口定义
    /// </summary>
    public partial interface IDoAction
    {
        /// <summary>
        /// 执行动作的参数实例
        /// </summary>
        IDoActionArgument DoActionArgument { get; set; }
        /// <summary>
        /// 是否忽略执行过程中错误
        /// </summary>
        bool IgnoreError { get; set; }
        /// <summary>
        /// 执行动作
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="IgnoreError"></param>
        void Do(IDoActionArgument arg, bool IgnoreError);
      
    }

}