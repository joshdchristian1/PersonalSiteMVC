using System.ComponentModel.DataAnnotations;
namespace PersonalSite.Models
{
    public class ContactViewModel
    {
        

            //We can use Data Annotations to add validation to our model.  This is useful when we have required fields or need certain types of information.

            [Required(ErrorMessage = "*Name is required")] // Makes the field required
            public string Name { get; set; }
            [Required(ErrorMessage = "*Email is required")]
            [DataType(DataType.EmailAddress)] //Cetain formatting is expected (@ symbol, .com, etc.)
            public string Email { get; set; }
            [Required(ErrorMessage = "*Subject required")]
            public string Subject { get; set; }
            [Required(ErrorMessage = "*Message is required")]
            [DataType(DataType.MultilineText)]//Makes the textbox for this field bigger
            public string Message { get; set; }


        
    }
}
