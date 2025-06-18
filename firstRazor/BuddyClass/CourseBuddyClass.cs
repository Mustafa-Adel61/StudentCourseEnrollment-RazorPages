using System.ComponentModel.DataAnnotations;

namespace firstRazor.BuddyClass
{
    public class CourseBuddyClass
    {
        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Course Title is required")]
        [MinLength(3, ErrorMessage = "Course Title cannot be longer than 3 characters")]
        public required string Title { get; set; }
    }
}
