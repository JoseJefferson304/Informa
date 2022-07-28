using Informa.Context;
using Informa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Informa.Controllers
{
    public class ProdutoController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Produtos
        public ActionResult Index()
        {
            return View(context.Produtos.OrderBy(c => c.Descricao));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}