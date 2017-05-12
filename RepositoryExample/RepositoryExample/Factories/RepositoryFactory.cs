using RepositoryExample.Interfaces;
using RepositoryExample.Models;
using RepositoryExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryExample.Factories
{
    //  This class's entire function is to decide which 
    //  repository to hand as a dependency
    public static class RepositoryFactory
    {
        public static IRepository<Employee> GetEmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }
}