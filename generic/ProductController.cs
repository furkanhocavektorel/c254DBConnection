using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using generic.entity;
using generic.service;
using generic.util;

namespace generic
{
    internal class ProductController
    {
        IProductService productService=new ProductService();

        
        public void save()
        {
            productService.save(new Product());
        }


        public void getByName() {
            productService.getByName(new Product());
        }


    }
}
