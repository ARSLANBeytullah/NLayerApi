using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Dtos
{
    public class ProductDto:BaseDto  //DTO'lar sadece son kullanıcıları ilgilendiren bilgiler içermeli. Navigation Property'leri içermemelidir.
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
