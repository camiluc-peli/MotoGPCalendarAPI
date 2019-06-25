using MotoGPCalendar.Data.Repositories;
using MotoGPCalendar.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGPCalendar.Business.Handlers
{
    public class MotoGPEventHandler
    {
        private IMotoGPEventRepository _repo;

        public MotoGPEventHandler(IMotoGPEventRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<EventDTO>> GetAllAsync()
        {
            var list = await _repo.GetAllAsync();
                
            return list.Select(
            x => new EventDTO
            {
                EventDate = x.EventDate,
                EventName = x.EventName,
                CircuitName = x.Circuit.Name,
                CountryName = x.Circuit.Country.Name
            }).OrderByDescending(x => x.EventDate).ToList();
        }
        public async Task<EventDetailsDTO> GetByIdAsync(int id)
        {
            var ev = await _repo.GetByIdAsync(id);

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
