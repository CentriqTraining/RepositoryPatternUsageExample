using RepositoryExample.Interfaces;
using RepositoryExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryExample.Repositories
{
    public class FakeEmployeeRepositoryForTesting :IRepository<Employee>
    {
        public bool Delete(int IDtoDelete)
        {
            return true;
        }
        public bool Delete(Employee itemToDelete)
        {
            return true;
        }
        public Employee Find(int ID)
        {
            return new Models.Employee()
            {
                ID = ID,
                FirstName = "Mike",
                LastName = "Rissen"
            };
        }
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>()
            {
                new Employee() { ID=1, FirstName = "Mike", LastName = "Rissen" },
                new Employee() {ID=2, FirstName="Ranger", LastName = "Smith" }
            };
        }
        public bool Insert(Employee itemToAdd)
        {
            return true;
        }
        public bool Update(Employee itemToUpdate)
        {
            return true;
        }
    }
}