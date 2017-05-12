using RepositoryExample.Interfaces;
using RepositoryExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryExample.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public bool Delete(int IDtoDelete)
        {
            using (var db = new ToonCtx())
            {
                var lookup = db.Employees.Find(IDtoDelete);
                if (lookup == null)
                {
                    return false;
                }
                else
                {
                    db.Employees.Remove(lookup);
                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                        // log error
                    }
                }
            }
        }
        public bool Delete(Employee itemToDelete)
        {
            return Delete(itemToDelete.ID);
        }
        public Employee Find(int ID)
        {
            using (var ctx = new ToonCtx())
            {
                return ctx.Employees.Find(ID);
            }
        }
        public IEnumerable<Employee> GetAll()
        {
            using (var db = new ToonCtx())
            {
                return db.Employees.ToList();
            }
        }
        public bool Insert(Employee itemToAdd)
        {
            using (var db = new ToonCtx())
            {
                db.Employees.Add(itemToAdd);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    // log error
                }
            }
        }
        public bool Update(Employee itemToUpdate)
        {
            using (var db = new ToonCtx())
            {
                var lookup = db.Employees.Find(itemToUpdate.ID);
                if (lookup == null)
                {
                    return false;
                }
                else
                {
                    db.Entry(lookup).CurrentValues.SetValues(itemToUpdate);
                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                        // log exception
                    }
                }
            }
        }
    }
 }