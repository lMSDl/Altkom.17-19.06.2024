﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.I
{
    internal class PlainText : IElement
    {
        public string Text { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        /*public string ToHtml()
        {
            return Text;
        }*/
    }
}
