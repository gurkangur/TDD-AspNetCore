using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Model;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository
    {
        List<Products> GetAll();
    }
}
