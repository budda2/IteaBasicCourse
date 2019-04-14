using System;

namespace ExampleWithFakeDb.Buisness
{
    public interface IPurchase
    {
        decimal Cost { get; }
        DateTime PurchaseDate { get; }
    }
}