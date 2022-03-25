using RestWithASP_NET5Udemy.Data.Converter.Contract;
using RestWithASP_NET5Udemy.Data.VO;
using RestWithASP_NET5Udemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP_NET5Udemy.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Author = origin.Author,
                Id = origin.Id,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }        

        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Author = origin.Author,
                Id = origin.Id,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Title = origin.Title
            };
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(x => Parse(x)).ToList();
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(x => Parse(x)).ToList();
        }
    }
}
