﻿using BaiTapTuan01.DTO.Response;
using BaiTapTuan01.Models;
using BaiTapTuan01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapTuan01.Services
{
    public class CategoryService
    {
        readonly private CategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<CategoryRender> GetAll()
        {
            var categories = categoryRepository.GetAll();
            var categoryRenders = categories.Select(category => new CategoryRender(category)).ToList();
            return categoryRenders;
        }
    }
}