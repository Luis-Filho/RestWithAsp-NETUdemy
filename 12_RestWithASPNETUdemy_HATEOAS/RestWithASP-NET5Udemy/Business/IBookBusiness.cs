using RestWithASP_NET5Udemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO Book);
        void Delete(long id);
    }
}
