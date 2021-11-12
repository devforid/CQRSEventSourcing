using CQRSEventSourcing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSEventSourcing.Events
{
    public class ChangeAgeCommand: Command
    {
        public Person person;
        public int Age;

        public ChangeAgeCommand(Person person, int age)
        {
            this.person = person;
            Age = age;
        }
    }
}
