using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
using System.Collections.Generic;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasServices _vendasServices;
        private readonly DepartamentoServices _departamentoServices;

        public VendasController(VendasServices vendasServices, DepartamentoServices departamentoServices)
        {
            _vendasServices = vendasServices;
            _departamentoServices = departamentoServices;

        }

        public IActionResult Index()
        {
            var list = _vendasServices.FindAll();
            return View(list);
        }
        public IActionResult Criar()
        {
            var departamentos = _departamentoServices.EncontrarTudo();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendasServices.Insert(vendedor);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _vendasServices.EncotrarPorId(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (int id)
        {
            _vendasServices.Remover(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detalhes(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _vendasServices.EncotrarPorId(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Editar(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _vendasServices.EncotrarPorId(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            List<Departamento> departamentos = _departamentoServices.EncontrarTudo();
            VendedorFormViewModel viewModel = new VendedorFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, Vendedor vendedor)
        {
            if (id != vendedor.Id)
            {
                return BadRequest();
            }
            try
            {
                _vendasServices.Update(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
