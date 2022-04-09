using System;
using System.Linq;

namespace BookstoreProject.Models
{
    public class EFBookstoreProjectRepository: IBookstoreProjectRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreProjectRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;

        public void CreateProduct(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteProduct(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveProduct(Book b)
        {
            context.SaveChanges();
        }
    }
}
