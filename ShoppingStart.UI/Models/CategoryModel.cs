using ShoppingStart.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static ShoppingStart.ENT.Entities;

namespace ShoppingStart.UI.Models
{
    public class CategoryModel
    {
        public List<CategoriesDto> clist { get; set; }
        public List<ProductDto> plist { get; set; }
        //sayfa açıldığında plist in boş olması için ctor tanımlanır
        public List<Categories> ylist { get; set; }
        public Categories category { get; set; }
        public CategoryModel()
        {
            this.plist = new List<ProductDto>();
           
        }
    }
}