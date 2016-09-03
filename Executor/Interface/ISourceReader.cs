using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{

    /// <summary>
    /// 源读取器的接口定义
    /// </summary>
    public partial interface ISourceReader
    {
        /// <summary>
        /// 读取活动的主键
        /// </summary>
        string ReaderKey { set; get; }
        /// <summary>
        /// 执行过程中的错误信息
        /// </summary>
        string ErrorMessage { get; set; }
        /// <summary>
        /// 源读取器的类型名称
        /// </summary>
        string ReaderType { get; }
        /// <summary>
        /// 读取Read方法所需要的参数实例
        /// </summary>
        IReaderArgument ReaderArg { get; set; }
        /// <summary>
        /// 执行读取前的动作
        /// </summary>
        /// <param name="actions"></param>
        /// <returns></returns>
        bool PreAction(IList<IDoAction> actions);
        /// <summary>
        /// 执行读取方法
        /// </summary>
        /// <param name="scheduler">执行排程，检查是否可以执行设定的读取方法</param>
        /// <param name="readerArg">读取执行时所需要的参数实例</param>
        /// <returns></returns>
        bool Read(IScheduler scheduler, IReaderArgument readerArg, ISaveArgument saveArgs);
        /// <summary>
        /// 执行读取后的动作
        /// </summary>
        /// <param name="actions">执行动作集合</param>
        /// <returns></returns>
        bool PostAction(IList<IDoAction> actions);
    }

}