using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShoppingStart.REP.Repositories;

namespace ShoppingStart.BL
{
    public class BusinessManager
    {
        public class CategoriesManager : CategoriesRepository
        {
            public List<CategoriesDto> CategoriList()
            {
                return GenelListe().Select(x => new CategoriesDto
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName
                }).ToList();
            } //bu metodu kullanabilmek için dto açtık
        }
        public class ProductsManager : ProductsRepository
        {
        }
        public class SuppliersManager : CategoriesRepository
        {
        }
    }
}
