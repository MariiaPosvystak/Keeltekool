using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Keeltekool.Models
{
    public class Opetaja
    {
        public int Id { get; set; }
        [Required]
        public string Nimi { get; set; }
        public string Kvalifikatsioon { get; set; }
        public string FotoPath { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}