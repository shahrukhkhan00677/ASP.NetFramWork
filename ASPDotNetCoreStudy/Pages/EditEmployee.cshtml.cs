using ASPDotNetCoreStudy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ASPDotNetCoreStudy.Pages
{
    public class EditEmpoyeeModel : PageModel
    {
        AppDBContext appDBContext { set; get; }
        [BindProperty]
        public Employee employee { get; set; }
        public EditEmpoyeeModel(AppDBContext data)
        {
            appDBContext = data;
        }
        public void OnGet(int id )
        {
            employee = appDBContext.Employees.Find(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                appDBContext.Employees.Update(employee);
                appDBContext.SaveChanges();
                return RedirectToPage("ShowEmployee");
            }
            else
            {
                return Page();
            }
        }
    }
}
