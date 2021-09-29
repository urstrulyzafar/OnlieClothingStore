using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineClothingStore.Models
{
    public class CustomerModel
    { 
        [Key]
        public int MemberId { get; set; }

        [Display(Name ="Firstname")]
        [Required(ErrorMessage ="Please Enter Firstname")]
        public string FirstName { get; set; }

        [Display(Name = "Laststname")]
        [Required(ErrorMessage = "Please Enter Lastname")]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Please Enter Contact Number")]
        public string ContactNumber { get; set; }

        
    }
}
