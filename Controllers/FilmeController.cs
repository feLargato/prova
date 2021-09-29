using System.Security.AccessControl;
using System.Net.Http.Headers;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prova.Model;
using prova.Data;
using System.Collections.Generic;
using System.Linq;

namespace prova.Controllers
{
    [ApiController]
    [Route("api/filme")]
    public class FilmeController : ControllerBase
    {
        private Context _context;
        public FilmeController(Context context) 
        {
            _context = context;
        }

       [HttpPost]
       [Route("add")]
       public Filme CreateFilme(Filme filme)
       {
           _context.Filmes.Add(filme);
           _context.SaveChanges();
           return filme;
       }

       [HttpGet]
       [Route("list")]
       public List<Filme> List() => _context.Filmes.ToList();
 

    }
}
