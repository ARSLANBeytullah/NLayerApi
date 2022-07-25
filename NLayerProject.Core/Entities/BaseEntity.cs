using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Entities
{
    public abstract class BaseEntity //Abstract yapıyoruz böylece new'lenemeyen bir yapı inşa ediyoruz.Soyut bir nesnedir.Ortak olan property'leri buraya yazdım.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;

    }
}
