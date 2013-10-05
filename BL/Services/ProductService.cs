﻿using ApiSample.BL.Interfaces;
using ApiSample.DA.Interfaces;
using ApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.BL.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository ProductRepository { get; set; }

        public ProductService(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
        }

        public IEnumerable<ProductForCategoryModel> GetProductByCategoryId(int categoryId)
        {
            return this.ProductRepository.GetProductByCategoryId(categoryId);
        }
    }
}