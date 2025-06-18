using firstRazor.Data;
using firstRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace firstRazor.Pages.StudentPage
{
    public class IndexModel : PageModel
    {
        ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students = _context.Students.Include(c=>c.Enrollments).ThenInclude(c=>c.Course).ToList();
        }
        //For Delete
        public IActionResult OnPostDelete(int? id)
        {
            var student1 = _context.Students.Find(id);
            if (student1 != null)
            {
                _context.Students.Remove(student1); 
                _context.SaveChanges();
            }
            Students = _context.Students.Include(c=>c.Enrollments).ThenInclude(c=>c.Course).ToList();
            return Page();
        }
        //For Search
        public IActionResult OnPost(string? stdName)
        {
            Students = _context.Students.Include(c=>c.Enrollments).ThenInclude(c=>c.Course).Where(c => c.FullName.Contains(stdName)).ToList();
            return Page();
        }
    }
}
