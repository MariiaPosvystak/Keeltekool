using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Keeltekool.Models
{
    public enum Staatus
    {
        Ootel,
        Kinnitatud,
        Tuhistatud
    }
    public class Registreerimine
    {
        public int Id { get; set; }
        public int KoolitusId { get; set; }
        public Koolitus Koolitus { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
        public Staatus Staatus { get; set; }
    }
}