
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace PersonalSite.UI.MVC.Models
{
    public class ContactViewModel
    {
       
        [Required(ErrorMessage = "*Name is required")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "*Valid Email is required")] 
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is required")]
        [UIHint("MultilineText")] 
        public string Message { get; set; }
      
    }
}