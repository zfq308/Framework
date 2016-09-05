using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    public class KeyItem
    {
        public Guid Key { get; set; }
        public string ReaderType { get; set; }
        public string ReaderKeyHashValue { get; set; }
        public DateTime CreatedTime { get; set; }
        public string OperationMan { get; set; }
        public string ReaderKeyValue { get; set; }

    }

}
