using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroupWork.Data;
using GroupWork.Models;

namespace GroupWork.Pages.Contactos
{
    public class CreateModel : PageModel
    {
        private readonly GroupWork.Data.GroupWorkContext _context;

        public CreateModel(GroupWork.Data.GroupWorkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contacto Contacto { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Contacto == null || Contacto == null)
            {
                return Page();
            }

            _context.Contacto.Add(Contacto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
