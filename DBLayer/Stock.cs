using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class Stock
    {
        public int ID { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public virtual List<ItemInStock> ItemInStocks { get; set; }
    }
}
