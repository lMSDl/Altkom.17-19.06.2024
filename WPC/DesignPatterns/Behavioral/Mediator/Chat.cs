using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    internal class Chat : IMediator
    {
        private readonly ICollection<ChatMemeber> _chatMembers = new List<ChatMemeber>();
        public void Join(ChatMemeber member)
        {
            _chatMembers.Add(member);
        }

        public void Quit(ChatMemeber member)
        {
            _chatMembers.Remove(member);
        }

        public void Send(string from, string message)
        {
            var sender = _chatMembers.Single(x => x.Nick == from);
            var query = _chatMembers.Where(x => x != sender);
            if (sender is ChatBot)
                query = query.Where(x => x is not ChatBot);

            query.ToList().ForEach(x => x.Receive(from, message, false));
        }

        public void Send(string from, string to, string message)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }
    }
}
