using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudRapido.Models;

namespace CrudRapido.Controllers
{
    public class HomeController : Controller
    {
        protected readonly ApplicationContext contexto;

        public HomeController(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar(Pessoa pessoa)
        {
            contexto.Set<Pessoa>().Add(pessoa);
            contexto.SaveChanges();
            List<Pessoa> pessoas = contexto.Set<Pessoa>().ToList();

            return View(pessoas);
        }

        public IActionResult Update(Pessoa pessoa)
        {
            contexto.Set<Pessoa>().Update(pessoa);
            contexto.SaveChanges();

            return View(pessoa);
        }

        public IActionResult Remove(Pessoa pessoa)
        {
            contexto.Set<Pessoa>().Remove(pessoa);
            contexto.SaveChanges();

            return View(pessoa);
        }

        public IActionResult Select(Pessoa pessoa)
        {
            var pessoal = contexto.Set<Pessoa>().Find(pessoa.Id);

            return View(pessoal);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
