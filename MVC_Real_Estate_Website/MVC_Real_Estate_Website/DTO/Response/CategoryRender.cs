using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BaiTapTuan01.Models;

namespace BaiTapTuan01.DTO.Response
{
    public class CategoryRender
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string meta { get; set; }

        public CategoryRender(int id, string name, string link, string meta, bool? hide, int? order, DateTime? datebegin)
        {
            this.id = id;
            this.name = name;
            this.link = link;
            this.meta = meta;
        }

        public CategoryRender(Category category)
        {
            this.id = category.id;
            this.name = category.name;
            this.link = category.link;
            this.meta = category.meta;
        }
        public CategoryRender()
        {
        }
    }
}