using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.model.Model
{
    [Table("Inviter")]
    public class Inviter
    {

        [Key]
        [Required]
        public int InviterId { get; set; }
        public string InviterName { get; set; }
        public string InviterPhoneNumber { get; set; }
        public string? InviterMail { get; set; }
    }

}
