using System;
using System.Linq;

namespace BookstoreProject.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);

    }
}
