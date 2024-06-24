﻿namespace KhumaloCraft
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> DisplayProducts(string sTerm = "", int categoryId = 0);
        Task<IEnumerable<Category>> Categories();
    }
}