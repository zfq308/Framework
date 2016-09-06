using Executor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Implements.Keys
{
    public class KeysGeneratorBasedSQLServer : IKeysGenerator
    {
        public bool AddKeysIntoRepository(List<TestCase> TestCases)
        {
            // TODO: Insert the List<KeyItem> into KeysTable and KeysDetails Tables.

            return true;
        }

        public List<TestCase> GetKeysCollectionsByKey(Guid Key)
        {
            //TODO: GetKeys by value of key
            throw new NotImplementedException();
        }
    }
}
