using firstRazor.Data;
using firstRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace firstRazor.Pages.StudentPage
{
    public class CreateModel : PageModel
    {
        ApplicationDbContext _context;

        [BindProperty]
        public Student student { get; set; }
        [BindProperty]
        public List<SelectListItem> Enrollments { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            student =new Student();
            Enrollments = _context.Courses.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Title
            }).ToList();
        }
        public IActionResult OnPost( int[] SelectedCourseIds) 
        {
            if (ModelState.IsValid) 
            {
                foreach (var courseId in SelectedCourseIds)
                {
                    _context.Enrollments.Add(new Enrollment
                    { //addNew student and add it to enrolment
                        Student = student,
                        CourseId = courseId,
                        Grade = "0"

                    });
                    _context.SaveChanges();
                }
                return RedirectToPage("Index");
            }
            Enrollments = _context.Courses.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Title
            }).ToList();
            return Page();
        }

    }
}
