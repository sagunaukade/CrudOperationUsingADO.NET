using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUDOperationUsingADO.NET.Models
{
    public class EmployeeModel
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter The Name ")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter The Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        //[DataType(DataType.MobileNumber)]
        //[DataType(DataType.MobileNumber)]
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Mobile { get; set; }

        //[Required(ErrorMessage = "Please Enter Mobile No")]
        //[Display(Name = "Mobile")]
        //[StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
        //public string MobileNo { get; set; }


        [Required(ErrorMessage = "Please Enter The Date Of Birth")]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{mm/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DOB { get; set; }


    }
}