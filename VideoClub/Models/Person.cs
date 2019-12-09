using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoClub.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string PersonType { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Gender { get; set; }
        public int ReviewID { get; set; }
        public int PaymentID  { get; set; }





    }
}
