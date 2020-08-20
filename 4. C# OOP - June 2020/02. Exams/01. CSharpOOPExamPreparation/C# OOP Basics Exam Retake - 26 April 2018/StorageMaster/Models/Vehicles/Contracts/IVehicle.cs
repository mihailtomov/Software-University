﻿using StorageMaster.Models.Products;
using System.Collections.Generic;

namespace StorageMaster.Models.Vehicles.Contracts
{
    public interface IVehicle
    {
        int Capacity { get; }

        IReadOnlyCollection<Product> Trunk { get; }

        bool IsFull { get; }

        bool IsEmpty { get; }

        void LoadProduct(Product product);

        Product Unload();
    }
}
