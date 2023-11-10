using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Range(0,25)]
        [Display(Name = "Default Number of Days")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
