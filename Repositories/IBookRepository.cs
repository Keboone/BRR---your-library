using LibraryFinal.Models;

namespace LibraryFinal.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetBook(int itemId);
        
    }
}
