using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipProgramı582.Models
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        //Bir kategorinin birden fazla ürünü olabilir
        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
