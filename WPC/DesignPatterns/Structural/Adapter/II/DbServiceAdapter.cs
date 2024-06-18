using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    internal class DbServiceAdapter : IPeopleService
    {
        private readonly DbService _dbService;

        public DbServiceAdapter(DbService dbService)
        {
            _dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {
            return _dbService.Read().Select(x => new Person { Name = $"{x.LastName} {x.FirstName}", Age = (DateTime.Now.Year - x.BirthDate.Year) });
        }
    }
}
