using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.model.Model
{
    [Table("InventionEvent")]
    public class InventionEvent
    {

        [Key]
        [Required]
        public int InventionEventId { get; set; }
        public string? InvatorId { get; set; }
        [ForeignKey(nameof(InvatorId))]
        public string? HallId { get; set; }
        [ForeignKey(nameof(HallId))]
        public string CountPeople { get; set; }
        public int Payment { get; set; }


    }

}
