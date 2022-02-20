using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;

namespace PetVet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult Agendamento()
        {
            return View("Agendamento");
        }
        [HttpPost]
        public IActionResult Cadastro(DadosAg itemForm){
            Solicite.Sol.AdicionarPedido(itemForm);
            //return View("/Home/Model/Listagem");
           return RedirectToAction("Retorno", "Home");
        }
        public IActionResult Retorno(){
            List<DadosAg> listagemDaMem = Solicite.Sol.Show();
            return View(listagemDaMem);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
