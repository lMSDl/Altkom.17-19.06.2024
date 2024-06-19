using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {

        public string Nick { get; set; }
        private IMediator? mediator;
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                if (mediator != null)
                    mediator.Quit(this);
                mediator = value;
                if (mediator != null)
                    mediator.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}
