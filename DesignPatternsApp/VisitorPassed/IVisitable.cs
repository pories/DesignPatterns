﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPassed
{
    public interface IVisitable
    {
        void HandleVisitor(IVisitFoo visitor);
    }
}
