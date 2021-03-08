using ProjetoWeb1.Models;
using ProjetoWeb1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoWeb1.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult CadastroProdutos()
        {
            return View();
        }
        public ActionResult ListarProdutos()
        {
            return View();
        }
        public ActionResult DeleteProdutos()
        {
            return View();
        }
        public ActionResult AtualizarProdutos()
        {
            return View();
        }

      [HttpPost]
      public ActionResult CadastrarProdutos(Produtos produtos)
        {
            var service = new ProdutosService();
            service.CadastrarProdutos(produtos);
            return View("CadastroProdutos");
        }
        [HttpGet]
        public ActionResult BuscarProdutos()
        {

            var service = new ProdutosService();
            
            return View(service.ListarProdutosService());
        }
        [HttpPost]
        public ActionResult DeletarProdutos(Produtos produtos)
        {
            var service = new ProdutosService();
            service.DeletarProdutosService(produtos);
            return View("DeleteProdutos");
        }
        [HttpPost]

        public ActionResult AtualizarProdutos(Produtos produtos)
        {
            var service = new ProdutosService();
            service.AtualizaProdutosService(produtos);
            return View("AtualizarProdutos");
        }
    }
}