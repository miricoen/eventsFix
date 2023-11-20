using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.model.Model
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        [Required]
        public int ManaId { get; set; }
        public string Mana { get; set; }
        public string ManaStatus { get; set; }
        public string Kashrut { get; set; }
        public string Price { get; set; }


    }
}
