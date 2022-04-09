using System;
using System.Linq;

namespace BookstoreProject.Models
{
    public interface IBookstoreProjectRepository
    {
        IQueryable<Book> Books { get; }
        void SaveProduct(Book b);
        void CreateProduct(Book b);
        void DeleteProduct(Book b);
    }
}
