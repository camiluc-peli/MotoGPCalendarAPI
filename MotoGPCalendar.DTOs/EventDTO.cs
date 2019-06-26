using System;

namespace MotoGPCalendar.DTOs
{
    public class EventDTO
    {
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string CircuitName { get; set; }
        public string CountryName { get; set; }
    }
}
