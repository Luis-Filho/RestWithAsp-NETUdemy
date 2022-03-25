using RestWithASP_NET5Udemy.Model;
using RestWithASP_NET5Udemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Repository.Implementation
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private MySQLContext _context;
        public BookRepositoryImplementation(MySQLContext context) =>
            _context = context;

        public List<Book> FindAll() =>
            _context.Books.ToList();

        public Book FindById(long id) =>
            _context.Books.SingleOrDefault(x => x.Id == id);
        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return book;
        }

        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(x => x.Id == id);

            if (result != null)
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
        }

        public Book Update(Book book)
        {
            if (!Exists(book.Id)) return null;

            var result = _context.Books.SingleOrDefault(x => x.Id == book.Id);

            if (result != null)
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            return book;
        }

        public bool Exists(long id) =>
            _context.Books.Any(x => x.Id == id);
    }
}
