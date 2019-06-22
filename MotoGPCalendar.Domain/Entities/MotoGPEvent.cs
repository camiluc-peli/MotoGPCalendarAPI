using System;

namespace MotoGPCalendar.Domain.Entities
{
    class MotoGPEvent
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public Circuit Circuit { get; set; }
    }
}
