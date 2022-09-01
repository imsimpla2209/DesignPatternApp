using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2GethighGUI.Function.Validation
{
    public class UserValidation
    {
        [Required(ErrorMessage = "User name field cannot be blank")]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Do not enter da invalid user name")]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "Valud Name Please!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age field cannot be blank")]
        [Range(14, 60, ErrorMessage = "Age must be in da range of 14 to 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Identity card field cannot be blank")]
        [RegularExpression(@"^.*[0-9]", ErrorMessage = "Valid Number Please!")]
        [StringLength(14, MinimumLength = 9, ErrorMessage = "Only Accept 9 characters or 12 charactors NIC")]
        public string IdentityCard { get; set; }

        [Required(ErrorMessage = "{0} This field cannot be blank"), DataType(DataType.Currency)]
        public double Income { get; set; }
    }
}