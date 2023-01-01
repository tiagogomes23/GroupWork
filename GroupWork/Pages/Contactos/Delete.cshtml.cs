using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroupWork.Data;
using GroupWork.Models;

namespace GroupWork.Pages.Contactos
{
    public class DeleteModel : PageModel
    {
        private readonly GroupWork.Data.GroupWorkContext _context;

        public DeleteModel(GroupWork.Data.GroupWorkContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Contacto Contacto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Contacto == null)
            {
                return NotFound();
            }

            var contacto = await _context.Contacto.FirstOrDefaultAsync(m => m.Id == id);

            if (contacto == null)
            {
                return NotFound();
            }
            else 
            {
                Contacto = contacto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Contacto == null)
            {
                return NotFound();
            }
            var contacto = await _context.Contacto.FindAsync(id);

            if (contacto != null)
            {
                Contacto = contacto;
                _context.Contacto.Remove(Contacto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
