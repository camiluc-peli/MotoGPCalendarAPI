using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;
namespace MotoGPCalendar.Data.Repositories
{
    public interface ICircuitRepository
    {
        List<Circuit> GetAll();
        Circuit GetById(int id);
        void Insert(Circuit circuit);
    }
}
