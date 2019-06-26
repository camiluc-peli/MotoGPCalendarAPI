using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MotoGPCalendar.Data.Repositories
{
    public interface IMotoGPEventRepository
    {
        Task<List<MotoGPEvent>> GetAllAsync();
        Task<MotoGPEvent> GetByIdAsync(int id);
    }
}