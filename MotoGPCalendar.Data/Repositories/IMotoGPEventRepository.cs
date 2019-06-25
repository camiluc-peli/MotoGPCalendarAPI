using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;

namespace MotoGPCalendar.Data.Repositories
{
    public interface IMotoGPEventRepository
    {
        List<MotoGPEvent> GetAll();
        MotoGPEvent GetById(int id);
    }
}