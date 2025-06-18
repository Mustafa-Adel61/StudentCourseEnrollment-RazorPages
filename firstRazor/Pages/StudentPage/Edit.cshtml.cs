using firstRazor.Data;
using firstRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace firstRazor.Pages.StudentPage
{
    public class EditModel : PageModel
    {
        ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context=context;
        }
        [BindProperty]
        public List<SelectListItem> Enrollments { get; set; }
        [BindProperty]
        public Student  student { get; set; }
        public IActionResult OnGet(int? id)
        {
            student = _context.Students.Find(id);
            Enrollments = _context.Courses.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Title
            }).ToList();
            return Page();
        }
        public IActionResult OnPost(int[] SelectedCourseIds) 
        {
            if (ModelState.IsValid)
            {
                if (SelectedCourseIds.Count() != 0)
                {
                    foreach (var courseId in SelectedCourseIds)
                    {
                        _context.Enrollments.Add(new Enrollment
                        { //addNew student and add it to enrolment
                            Student = student,
                            CourseId = courseId,
                            Grade = "0"

                        });
                        _context.Students.Update(student);
                        _context.SaveChanges();
                    }
                }
                else 
                {
                    _context.Students.Update(student); 
                    _context.SaveChanges(); 
                }
                return RedirectToPage("Index");
            }
            else
            {
                Enrollments = _context.Courses.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Title
                }).ToList();
                return Page();
            }

        }
    }
}
