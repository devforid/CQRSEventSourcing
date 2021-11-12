using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSEventSourcing.Events
{
    public class EventBroker
    {
        public List<Event> events = new List<Event>();
        public event EventHandler<Command> commands;
        public event EventHandler<Query> queires;

        public void Command(Command command)
        {
            commands?.Invoke(this, command);
        }
        public T Query<T>(Query query)
        {
            queires?.Invoke(this, query);
            return (T)query.Result;
        }
    }
}
