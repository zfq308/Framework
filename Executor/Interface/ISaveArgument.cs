using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{
    /// <summary>
    /// ��������Ľӿ���
    /// </summary>
    public partial interface ISaveArgument
    {
        /// <summary>
        /// ����Ŀ��ö��
        /// </summary>
        EnumSaveTarget SaveTarget { get; set; }
        /// <summary>
        /// ����������Դ���
        /// </summary>
        int RetryTime { get; set; }
    }

    /// <summary>
    /// ����Ŀ��ö��
    /// </summary>
    public enum EnumSaveTarget
    {
        /// <summary>
        /// ���浽Զ�����ݿ�
        /// </summary>
        RemoteDatabaseRecord = 1,
        /// <summary>
        /// ���浽ShareFolder
        /// </summary>
        SaveToShareFolder = 2,
        /// <summary>
        /// ѹ��Ŀ����󲢱��浽ShareFolder
        /// </summary>
        ZipAndSaveToShareFolder = 3,
    }
}