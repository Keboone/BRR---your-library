using LibraryFinal.Models;

namespace LibraryFinal.Repositories
{
    public class BookRepository: IBookRepository
    {
        public DatabaseContext context;

        public BookRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public Book? GetBook(int id)
        {
            return context.Books.FirstOrDefault(book => book.Id == id);
        }
    }
}
