using CQRSEventSourcing.Events;
using CQRSEventSourcing.Models;
using System;

namespace CQRSEventSourcing
{
    class Program
    {
        static void Main(string[] args)
        {
            var eb = new EventBroker();
            var person = new Person(eb);
            eb.Command(new ChangeAgeCommand(person, 123));

            int age = eb.Query<int>(new AgeQuery { person = person });
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
