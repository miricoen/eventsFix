using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.model.Model
{
    [Table("InventionMenu")]
    public class InventionMenu
    {

        [Key]
        [Required]
        public int InventionEventId { get; set; }
        
        public int? ManaId { get; set; }
        [ForeignKey(nameof(ManaId))]
        public int CountProduct { get; set; }

    }

}
