using System;
using System.Collections.Generic;
using System.Text;

namespace MotoGPCalendar.Domain.Entities
{
    class MotoGPEvent
    {
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string CircuitName { get; set; }
        public string CountryName { get; set; }
        public double CircuitLength { get; set; }
        public  int CircuitCurves { get; set; }
        public double CircuitWidth { get; set; }
        public double CircuitLongerStraight { get; set; }
        public double CircuitRecord { get; set; }
    }
}
