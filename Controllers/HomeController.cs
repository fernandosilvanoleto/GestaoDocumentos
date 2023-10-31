using GestaoDocumentos.Models;
using GestaoDocumentos.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoDocumentos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public HomeController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Fernando Silva";
            home.Email = "fernandonoleto17@gmail.com";

            return View(home);
        }

        [HttpGet]
        public IActionResult Login(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("IdClienteLogado", string.Empty);
                    HttpContext.Session.SetString("NomeClienteLogado", string.Empty);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult LoginCliente(LoginModel loginModel)
        {
            if (ModelState.IsValid && loginModel != null)
            {
                try
                {
                    ClienteModel clienteModel = _clienteRepository.LoginCliente(loginModel);

                    HttpContext.Session.SetString("IdClienteLogado", clienteModel.Id.ToString());
                    HttpContext.Session.SetString("NomeClienteLogado", clienteModel.Nome);

                    return View("Menu", clienteModel);
                }
                catch (Exception)
                {
                    TempData["ErrorLogin"] = "Email ou senha incorretos! Tente novamente!";
                }

                return RedirectToAction("Login");
            }
            else
            {
                return View("Login");
            }
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
