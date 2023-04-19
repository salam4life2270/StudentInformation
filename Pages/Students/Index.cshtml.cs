using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentInformation.Data;
using StudentInformation.Models;

namespace StudentInformation.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentInformation.Data.StudentInformationContext _context;

        public IndexModel(StudentInformation.Data.StudentInformationContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
