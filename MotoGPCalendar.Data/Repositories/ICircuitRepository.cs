using System.Collections.Generic;
using MotoGPCalendar.Domain.Entities;
namespace MotoGPCalendar.Data.Repositories
{
    public interface ICircuitRepository
    {
        List<Circuit> GetAll();
        Circuit GetById(int id);
        void Insert(Circuit circuit);
    }
}
