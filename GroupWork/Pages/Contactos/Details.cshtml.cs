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
    public class DetailsModel : PageModel
    {
        private readonly GroupWork.Data.GroupWorkContext _context;

        public DetailsModel(GroupWork.Data.GroupWorkContext context)
        {
            _context = context;
        }

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
    }
}
