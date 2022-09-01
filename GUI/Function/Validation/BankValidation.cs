using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2GethighGUI.Function.Validation
{
    public class BankValidation
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "This is invalid card name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^.*[0-9]", ErrorMessage = "Valid Card Number Please!")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{1,2}/\d{1,2}/\d{4}$", ErrorMessage = "Wrong Date")]
        public string ExpiredDate { get; set; }
    }
}