using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {

        public ActionResult Visualizar()

        {

            Produto produto = GetProduto();
            return View(produto);

            //return new ContentResult { } { Content =}
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
            
            };
        }
    }
}
