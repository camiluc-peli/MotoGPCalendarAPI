using MotoGPCalendar.Domain.Entities;
using System.Collections.Generic;


namespace MotoGPCalendar.Data.Repositories
{
    public interface ICountryRepository
    {
        List<Country> GetAll();
        Country GetById(int id);
        void Insert(Country country);
    }
}
