using System;

namespace MotoGPCalendar.DTOs
{
    public class EventDetailsDTO
    {
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string CircuitName { get; set; }
        public string CountryName { get; set; }
        public double CircuitLength { get; set; }
        public int CircuitCurvesNumber { get; set; }
        public double CircuitWidth { get; set; }
        public double CircuitLongestStraight { get; set; }
        public double CircuitRecord { get; set; }
    }
}
