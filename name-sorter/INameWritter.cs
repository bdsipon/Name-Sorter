﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    interface INameWritter
    {
        void WriteNames(IEnumerable<Name> names);
    }
}
