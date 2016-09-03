using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Executor.Interface;
namespace Executor.Implements.Reader
{
    public class XOIReaderArgument : IReaderArgument
    {
        public string URL { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public int RetryTimes { get; set; }
    }

    public class DefaultScheduler : IScheduler
    {
        public bool Check()
        {
            return true;
        }
    }

    public class SaveXMLArgument : ISaveArgument
    {
        public EnumSaveTarget SaveTarget { get; set; }

        public int RetryTime { set; get; }

        public SaveXMLArgument(EnumSaveTarget _SaveTarget, int _RetryTime)
        {
            SaveTarget = _SaveTarget;
            RetryTime = _RetryTime;
        }
    }

    public class XOIReader : ISourceReader
    {
        #region Properties

        public IReaderArgument ReaderArg { get; set; }

        public string ReaderKey { get; set; }

        public string ReaderType
        {
            get
            {
                return "XOIReader";
            }
        }

        public string ErrorMessage { get; set; }

        #endregion

        public XOIReader(string readerKey)
        {
            ReaderKey = readerKey;
        }

        public bool PostAction(IList<IDoAction> actions)
        {
            throw new NotImplementedException();
        }

        public bool PreAction(IList<IDoAction> actions)
        {
            throw new NotImplementedException();
        }

        public bool Read(IScheduler scheduler, IReaderArgument readerArg, ISaveArgument saveArgs)
        {
            if (scheduler.Check() && readerArg != null && saveArgs != null)
            {
                ErrorMessage = "";
                bool ReadSuccess = false;
                bool SaveSuccess = false;
                StringBuilder sb = new StringBuilder("");

                XOIReaderArgument args = readerArg as XOIReaderArgument;
                string URL = args.URL;
                string account = args.account;
                string password = args.password;

                #region 读取阶段

                int ReadErrorTimes = 0;
                while (ReadErrorTimes < args.RetryTimes)
                {
                    try
                    {

                        // TODO: Access XOI 


                        ReadSuccess = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        sb.AppendLine("读取阶段出现异常，错误信息为：");
                        sb.Append(ex.Message);
                        sb.AppendLine();
                        ReadErrorTimes += 1;
                    }
                }

                #endregion

                if (ReadSuccess)
                {
                    #region 保存阶段

                    sb.Clear();

                    SaveXMLArgument saveXMLArgs = saveArgs as SaveXMLArgument;

                    int SaveErrorTimes = 0;

                    while (SaveErrorTimes < saveArgs.RetryTime)
                    {
                        try
                        {
                            switch (saveXMLArgs.SaveTarget)
                            {
                                case EnumSaveTarget.RemoteDatabaseRecord:
                                    //TODO: 
                                    break;
                                case EnumSaveTarget.SaveToShareFolder:
                                    //TODO: 
                                    break;
                                case EnumSaveTarget.ZipAndSaveToShareFolder:
                                    //TODO: 
                                    break;
                                default:
                                    break;
                            }
                            SaveSuccess = true;
                            break;
                        }
                        catch (Exception SaveEx)
                        {
                            sb.AppendLine("保存阶段出现异常，错误信息为：");
                            sb.Append(SaveEx.Message);
                            sb.AppendLine();
                            SaveErrorTimes += 1;
                        }
                    }

                    #endregion
                }

                ErrorMessage = sb.ToString();
                return ReadSuccess && SaveSuccess;
            }
            else
            {
                //Log. 不符合调度条件，暂不执行
                ErrorMessage = "不符合调度条件，暂不执行";
                return false;
            }
        }
    }
}
