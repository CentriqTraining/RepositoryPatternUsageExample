using System.Collections.Generic;
using System.Data.Entity;

namespace RepositoryExample.Models
{
    internal class DBInit : DropCreateDatabaseAlways<ToonCtx>
    {
        protected override void Seed(ToonCtx context)
        {

            List<Employee> _Emps = null;
            _Emps = new List<Employee>()
            {
                new Employee() { FirstName = "Scooby", LastName = "Doo", ID = 1 },
                new Employee() { FirstName = "Scrappy", LastName = "Doo", ID=2 },
                new Employee() { FirstName = "Shaggy", LastName = "Rogers", ID=3 },
                new Employee() { FirstName = "Fred", LastName = "Jones", ID=4 },
                new Employee() { FirstName = "Daphne", LastName = "Blake",ID=5 },
                new Employee() { FirstName = "Velma", LastName = "Dinkley",ID=6 },
            };
            context.Employees.AddRange(_Emps);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}