﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interface
{
    public interface IKeysGenerator
    {
        bool AddKeysIntoRepository(List<KeyItem> keyItems);

        List<KeyItem> GetKeysCollectionsByKey(Guid Key);
    }
}
