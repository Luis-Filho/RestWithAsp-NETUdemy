using Microsoft.EntityFrameworkCore;
using RestWithASP_NET5Udemy.Model.Base;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private MySQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = context.Set<T>();
        }


        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindAll() =>
            dataset.ToList();

        public T FindById(long id) =>
            dataset.SingleOrDefault(x => x.Id == id);

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(x => x.Id == item.Id);
            if (result != null)
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch (Exception)
                {
                    throw;
                }
            else
                return null;
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(x => x.Id == id);
            if (result != null)
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }
        public bool Exists(long id) =>
           dataset.Any(x => x.Id == id);
    }
}
