using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShoppingStart.ENT.Entities;
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
            public List<ProductDto> Listele()
            {
                return GenelListe().Select(x => new ProductDto
                {
                    ProductID = x.ProductID,
                    CategoryID = (int)x.Categories.CategoryID,
                    ProductName = x.ProductName,
                    UnitPrice = (decimal)x.UnitPrice
                }).ToList();
                
            }
        }
        public class UsersManager : UsersRepository
        {
            public UserDto Denetle(string UserId,string Password)
            {
                Users user = null;
                user = Bul(UserId);
                if (user!=null)
                {
                    if (user.Password==Password)
                    {
                        UserDto UserDto = new UserDto();
                        UserDto.UserId = user.UserID;
                        UserDto.Role = user.Role;
                        return UserDto;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
