﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteElementA : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
        public string Name { get; set; }
    }
}
