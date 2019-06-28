using MotoGPCalendar.Data.Repositories;
using MotoGPCalendar.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGPCalendar.Business.Services
{
    public class MotoGPEventService
    {
        private IMotoGPEventRepository _repo;

        public MotoGPEventService(IMotoGPEventRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<EventDTO>> GetAllAsync()
        {
            var list = await _repo.GetAllAsync();
                
            return list.Select(
            x => new EventDTO
            {
                Id = x.Id,
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
                Id = ev.Id,
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
