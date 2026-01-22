using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Keeltekool.Models
{
    public class Koolitus
    {
        public int Id { get; set; }
        public int KeelekursusId { get; set; }
        public Keelekursus Keelekursus { get; set; }
        public int OpetajaId { get; set; }
        public Opetaja Opetaja { get; set; }
        public DateTime AlgusKuupaev { get; set; }
        public DateTime LoppKuupaev { get; set; }
        public decimal Hind { get; set; }
        public int MaxOsalejaid { get; set; }
        public ICollection<Registreerimine> Registreerimised { get; set; }
    }
}