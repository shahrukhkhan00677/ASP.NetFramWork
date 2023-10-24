using ASPDotNetCoreStudy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPDotNetCoreStudy.Pages
{
    public class AddEmployeeModel : PageModel
    {
        AppDBContext appDbContext  { get; set; }

        [BindProperty]
        public Employee employee { get; set; }
        public AddEmployeeModel(AppDBContext data)
        {
            appDbContext  = data;   


        }
        public void OnGet()
        {

        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                appDbContext.Employees.Add(employee);
                appDbContext.SaveChanges();
                return RedirectToPage("ShowEmployee");
            }
            else
            {
                return Page();
            }
        }
    }
}
