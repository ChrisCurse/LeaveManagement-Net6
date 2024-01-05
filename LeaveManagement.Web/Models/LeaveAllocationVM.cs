using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
         
        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage ="Invalid number Entered. Must be a number from 1 to 50")]
        public int NumberOfDays { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }
        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }
    }
}
