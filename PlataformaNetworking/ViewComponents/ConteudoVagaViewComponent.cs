﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlataformaNetworking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewComponents {
    public class ConteudoVagaViewComponent: ViewComponent {
        private readonly PlataformaNetworkingContext _context;

        public ConteudoVagaViewComponent(PlataformaNetworkingContext context) {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            return View(await _context.Vaga.ToListAsync());
        }
    }
}
