using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class editModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		[BindProperty]
		public Category? Category { get; set; }
		public editModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? id)
        {
			if(id != null && id != 0)
			{
				Category = _db.Categories.Find(id);
			}
        }
		public IActionResult OnPost()
		{
			if (ModelState.IsValid) 
			{
				_db.Update(Category);
				_db.SaveChanges();
				TempData["Success"] = "Category Updated Successfuly";
				return RedirectToPage("Index");
			}
			return Page();
		}
    }
}
