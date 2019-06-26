using Microsoft.EntityFrameworkCore;
using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MotoGPCalendar.Data.Repositories
{
    public class MotoGPEventRepository : IMotoGPEventRepository
    {
        private MotoGPCalendarContext _context;

        public MotoGPEventRepository(MotoGPCalendarContext context)
        {
            _context = context;
        }
        public async Task<List<MotoGPEvent>> GetAllAsync()
        {
            return await _context.MotoGPEvent.Include(c => c.Circuit).ThenInclude(c => c.Country).ToListAsync();
        }

        public async Task<MotoGPEvent> GetByIdAsync(int id)
        {
            return await _context.MotoGPEvent
                .Include(c => c.Circuit)
                .ThenInclude(c => c.Country)
                .SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}