using System;

namespace KogaTech.Domain.Core.Events
{
    public abstract class Message
    {
        public string MessageType { get; protected set; }
        public DateTime TimeStamp { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
            TimeStamp = DateTime.Now;
        }
    }
}
