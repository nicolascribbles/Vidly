using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class MembershipType
    {
        [Required]
        public string Name { get; set; }
        // In Entity Framework, every entity must have a key, which will be mapped to the primary key of the corresponding table in the database - by convention, we call it ID
        public int Id { get; set; }

        //because we don't need values more than 32,000
        public short SignUpFee { get; set; }

        //because the largest number we want to store is 12 for 12 months
        public byte DurationInMonths { get; set; }

        [Required]
        //because this is going to be a percentage between 0 and 100
        public byte DiscountRate { get; set; }
        


    }
}