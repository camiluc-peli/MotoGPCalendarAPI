using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MotoGPCalendar.Data.Repositories
{
    public class MotoGPEventRepository : IMotoGPEventRepository
    {
        private MotoGPCalendarContext _context;

        public MotoGPEventRepository(MotoGPCalendarContext context)
        {
            _context = context;
        }
        public List<MotoGPEvent> GetAll()
        {
            return _context.MotoGPEvent.ToList();
        }

        public MotoGPEvent GetById(int id)
        {
            return _context.MotoGPEvent.Find(id);
        }
    }
}