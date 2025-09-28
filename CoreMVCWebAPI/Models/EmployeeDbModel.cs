using System.ComponentModel.DataAnnotations;

namespace CoreMVCWebAPI.Models
{
    public class EmployeeDbModel
    {

        [Display(Name = "Employee ID")]
        public int EmpId { get; set; }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        public string Name { get; set; }

        [Display(Name = "Employee Email")]
        [Required(ErrorMessage = "Employee Email is required")]
        public string Email { get; set; }



    }
}
