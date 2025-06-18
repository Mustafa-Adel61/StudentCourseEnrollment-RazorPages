using System.ComponentModel.DataAnnotations;

namespace firstRazor.BuddyClass
{
    public class StudentBuddyClass
    {
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Student Name is required")]
        //[StringLength(10, ErrorMessage = "Student Name cannot be longer than 3 characters")]
        [MinLength(3, ErrorMessage = "Student Name cannot be longer than 3 characters")]
        public string FullName { get; set; }

    }
}
