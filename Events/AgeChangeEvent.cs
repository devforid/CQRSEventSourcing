using CQRSEventSourcing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSEventSourcing.Events
{
    public class AgeChangeEvent: Event
    {
        public Person person;
    }
}
