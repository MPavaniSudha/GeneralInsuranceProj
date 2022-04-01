using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralInsuranceProject.Models
{
    [Table("RegistrationTB")]
    public class RegistrationInfo
    {
        [Key]
        public int Reg_Id { get; set; }
        
        [Required(ErrorMessage ="Please Enter the Name")]
        public string CustomerName { get; set; }
        
        [Required(ErrorMessage = "Please Enter the EmailId")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Enter Email in the Correct format")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Birth Date is required")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public string DOB { get; set; }
        
        [Required(ErrorMessage = "Please Enter Your PhoneNumber")]
        [RegularExpression("/[0-9]{10}")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Please Enter the Password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please Enter the Confirm_Password")]
        [Compare("Password",ErrorMessage ="Password doesn't Match")]
        public string Confirm_Password { get; set; }
    }
}