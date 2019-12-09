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

        public PersonTypes PersonType { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public Genders Gender { get; set; }

        public int ReviewID { get; set; }

        public int PaymentID  { get; set; }
    }

    public enum PersonTypes
    {
        Admin,
        Customer,
        Creator
    }

    public enum Genders
    {
        Male,
        Female
    }
}
