using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PledgeAThon.Models.Domain
{
    public class ParticipantGroup
    {
        [Key]
        public int GroupId { get; set; }

        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
