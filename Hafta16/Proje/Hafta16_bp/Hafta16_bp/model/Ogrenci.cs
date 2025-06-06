using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta16_bp.model
{
    internal class Ogrenci
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public int Telefon { get; set; }
    }
}
