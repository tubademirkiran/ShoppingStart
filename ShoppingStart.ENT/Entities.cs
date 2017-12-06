using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStart.ENT
{
    public class Entities
    {
        public partial class Categories
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Categories()
            {
                this.Products = new HashSet<Products>();
            }

            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public byte[] Picture { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Products> Products { get; set; }
        }
        public partial class Products
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public Nullable<int> SupplierID { get; set; }
            public Nullable<int> CategoryID { get; set; }
            public string QuantityPerUnit { get; set; }
            public Nullable<decimal> UnitPrice { get; set; }
            public Nullable<short> UnitsInStock { get; set; }
            public Nullable<short> UnitsOnOrder { get; set; }
            public Nullable<short> ReorderLevel { get; set; }
            public bool Discontinued { get; set; }

            public virtual Categories Categories { get; set; }
            public virtual Suppliers Suppliers { get; set; }
        }
        public partial class Suppliers
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Suppliers()
            {
                this.Products = new HashSet<Products>();
            }

            public int SupplierID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string HomePage { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Products> Products { get; set; }
        }
    }
}
