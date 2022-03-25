using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithASP_NET5Udemy.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;
        public PersonServiceImplementation(MySQLContext context) =>
            _context = context;

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return person;
        }


        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(x => x.Id == id);

            if (result != null)
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }

        public List<Person> FindAll() =>
            _context.Persons.ToList();

        public Person FindById(long id) =>
            _context.Persons.SingleOrDefault(x => x.Id == id);

        public Person Update(Person person)
        {
            if (Exists(person.Id)) return new Person();

            var result = _context.Persons.SingleOrDefault(x => x.Id == person.Id);

            if (result != null)
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            return person;
        }

        private bool Exists(long id) =>
            _context.Persons.Any(x => x.Id == id);
    }
}
