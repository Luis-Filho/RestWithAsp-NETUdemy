using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Repository;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business.Implementation
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;
        public BookBusinessImplementation(IBookRepository repository) =>
            _repository = repository;

        public List<Book> FindAll() =>
            _repository.FindAll();

        public Book FindById(long id) =>
            _repository.FindById(id);

        public Book Create(Book book) =>
            _repository.Create(book);

        public void Delete(long id) =>
            _repository.Delete(id);

        public Book Update(Book book) =>
            _repository.Update(book);
    }
}
