﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOvertime
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }
}
