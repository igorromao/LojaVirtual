﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            String nome = HttpContext.Request.Form["nome"];
            String email = HttpContext.Request.Form["email"];
            String texto = HttpContext.Request.Form["texto"];

            return new ContentResult() { Content =string.Format( "Dados recebidos com sucesso! <br/> Nome: {0} <br/> E-mail: {1}  <br/> texto: {2}",nome,email,texto), ContentType = "text/html" };
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult CadastroCliente()
        {
            return View();
        }


        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}