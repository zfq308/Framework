using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{

    public class TestSuite
    {
        public Guid TestSuiteId { get; set; }
        public string TestSuiteName { get; set; }
        public string TestSuiteDescription { get; set; }

    }

    public class TestCase
    {
        /// <summary>
        /// Test case编号
        /// </summary>
        public Guid TestCaseId { get; set; }
        /// <summary>
        /// Test case所属的TestSuite编号
        /// </summary>
        public Guid BelongTestSuiteId { get; set; }
        /// <summary>
        /// TC的名称
        /// </summary>
        public string TestCaseName { get; set; }
        /// <summary>
        /// TestCase 禁用标志
        /// </summary>
        public bool DisableTheCase { get; set; }
        /// <summary>
        /// TC的描述
        /// </summary>
        public string TestCaseDescription { get; set; }
        /// <summary>
        /// TC 的Tag属性，已逗号分隔
        /// </summary>
        public string TagNames { get; set; }
        /// <summary>
        /// TestCase 案例启用标志
        /// </summary>
        public bool IsValid { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// TC的制定者
        /// </summary>
        public string OwnerName { get; set; }
        public int VerifyRuleId { get; set; }
    }




    public class TestCaseRawData
    {
        #region 设计时填入

        /// <summary>
        /// 测试案例编号
        /// </summary>
        public Guid TestCaseId { get; set; }
        /// <summary>
        /// 元数据处理器的类型名称
        /// </summary>
        public string RawDataHandlerType { get; set; }
        /// <summary>
        /// 用于多处理程序求余索引轮询
        /// </summary>
        public int RawDataHandlerIndex { get; set; }
        /// <summary>
        /// 原始数据来源
        /// </summary>
        public string RawDataSource { get; set; }

        public string RawDataQueryExpress1 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string RawDataQueryExpress2 { get; set; }
        public int TimeoutSeconds { get; set; }

        #endregion

        #region 运行时填入

        public string HandlerMachineName { get; set; }
        public string ReturnObjFilePath { get; set; }
        public string ReturnScaleValue { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int HandledFlag { get; set; }

        #endregion
    }

}