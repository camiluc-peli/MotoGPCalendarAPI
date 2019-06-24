using MotoGPCalendar.Data.Repositories;
using MotoGPCalendar.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace MotoGPCalendar.Business.Handlers
{
    public class MotoGPEventHandler
    {
        private IMotoGPEventRepository _repo;

        public MotoGPEventHandler(IMotoGPEventRepository repo)
        {
            _repo = repo;
        }
        public List<EventDTO> GetAll()
        {
            return _repo.GetAll().Select(
                x => new EventDTO
                {
                    EventDate = x.EventDate,
                    EventName = x.EventName,
                    CircuitName = x.Circuit.Name,
                    CountryName = x.Circuit.Country.Name
                }).OrderByDescending(x => x.EventDate).ToList();
        }
        public EventDetailsDTO GetById(int id)
        {
            var ev = _repo.GetById(id);

            return new EventDetailsDTO()
            {
                EventDate = ev.EventDate,
                EventName = ev.EventName,
                CircuitName = ev.Circuit.Name,
                CountryName = ev.Circuit.Country.Name,
                CircuitLength = ev.Circuit.Length,
                CircuitCurvesNumber = ev.Circuit.CurvesNumber,
                CircuitWidth = ev.Circuit.Width,
                CircuitLongestStraight = ev.Circuit.LongestStraight,
                CircuitRecord = ev.Circuit.Record
            };
        }
    }
}
