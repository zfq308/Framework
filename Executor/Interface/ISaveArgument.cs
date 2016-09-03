using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{
    /// <summary>
    /// 保存参数的接口类
    /// </summary>
    public partial interface ISaveArgument
    {
        /// <summary>
        /// 保存目标枚举
        /// </summary>
        EnumSaveTarget SaveTarget { get; set; }
        /// <summary>
        /// 保存出错重试次数
        /// </summary>
        int RetryTime { get; set; }
    }

    /// <summary>
    /// 保存目标枚举
    /// </summary>
    public enum EnumSaveTarget
    {
        /// <summary>
        /// 保存到远端数据库
        /// </summary>
        RemoteDatabaseRecord = 1,
        /// <summary>
        /// 保存到ShareFolder
        /// </summary>
        SaveToShareFolder = 2,
        /// <summary>
        /// 压缩目标对象并保存到ShareFolder
        /// </summary>
        ZipAndSaveToShareFolder = 3,
    }
}