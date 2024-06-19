namespace WPC.DesignPatterns.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Join(ChatMemeber member);
        void Quit(ChatMemeber member);
        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}