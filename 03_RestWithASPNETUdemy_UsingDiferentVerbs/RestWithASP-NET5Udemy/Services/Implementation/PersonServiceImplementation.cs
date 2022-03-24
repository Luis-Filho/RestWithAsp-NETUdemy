using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASP_NET5Udemy.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;


        public Person Create(Person person) =>        
            person;

        public void Delete(long id) =>
            throw new System.NotImplementedException();

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        private Person MockPerson(int i) =>
            new Person
            {
                Id = IncrementAndGet(),
                Gender = "Male",
                Address = "endereco" + i,
                FirstName = "nome " + i,
                LastName = "Sobrenome" + i
            };
        

        public Person FindById(long id) =>
            new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Luis",
                LastName = "Costa",
                Address = "Sobral-CE",
                Gender = "Male"
            };

        private long IncrementAndGet() =>
            Interlocked.Increment(ref count);

        public Person Update(Person person) =>
            person;
    }
}
