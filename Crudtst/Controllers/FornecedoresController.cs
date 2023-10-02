using Crudtst.Models;
using Crudtst.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Crudtst.Controllers
{
    public class FornecedoresController : Controller
    {

        private readonly IFornecedoresRepositorio _fornecedoresRepositorio;

        public FornecedoresController(IFornecedoresRepositorio fornecedoresRepositorio)
        {
            _fornecedoresRepositorio = fornecedoresRepositorio;
        }
        public IActionResult Index()
        {
            var fornecedores = _fornecedoresRepositorio.BuscarTodos();
            return View(fornecedores);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            Fornecedores fornecedor = _fornecedoresRepositorio.ListarPorId(id);
            return View(fornecedor);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            Fornecedores fornecedores = _fornecedoresRepositorio.ListarPorId(id);
            return View(fornecedores);
        }

        public IActionResult Apagar(int id)
        {
            _fornecedoresRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(Fornecedores fornecedores)
        {
            if (ModelState.IsValid)
            {
                _fornecedoresRepositorio.Adicionar(fornecedores);
                return RedirectToAction("Index");
            }

            return View(fornecedores);
            
        }

        [HttpPost]
        public IActionResult Alterar(Fornecedores fornecedores)
        {
            if (ModelState.IsValid)
            {
                _fornecedoresRepositorio.Atualizar(fornecedores);
                return RedirectToAction("Index");
            }

            return View("Editar", fornecedores);
        }
    }
}
