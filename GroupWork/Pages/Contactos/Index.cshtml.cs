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
    public class IndexModel : PageModel
    {
        private readonly GroupWork.Data.GroupWorkContext _context;

        public IndexModel(GroupWork.Data.GroupWorkContext context)
        {
            _context = context;
        }

        public IList<Contacto> Contacto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contacto != null)
            {
                Contacto = await _context.Contacto.ToListAsync();
            }
        }
    }
}
