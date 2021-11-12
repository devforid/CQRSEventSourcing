using CQRSEventSourcing.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSEventSourcing.Models
{
    public class Person
    {
        private int age;
        EventBroker broker;
        public Person(EventBroker eventBroker)
        {
            this.broker = eventBroker;
            broker.commands += BrokerOnCommnads;
            broker.queires += BrokerOnQueries;
        }

        private void BrokerOnQueries(object sender, Query query)
        {
            var ageQuery = query as AgeQuery;
            if(ageQuery != null && ageQuery.person == this)
            {
                ageQuery.Result = age;
            }
        }

        private void BrokerOnCommnads(object sender, Command command)
        {
            var changeAgeCommand = command as ChangeAgeCommand;
            if(changeAgeCommand != null  && changeAgeCommand.person == this)
            {
                age = changeAgeCommand.Age;
            }
        }
    }
}
