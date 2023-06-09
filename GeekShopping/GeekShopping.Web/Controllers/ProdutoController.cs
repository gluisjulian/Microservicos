﻿using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService ?? throw new ArgumentNullException(nameof(produtoService));
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.GetAllProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> ProdutoCreate()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ProdutoCreate(ProdutoModel model)
        {
            if (ModelState.IsValid)
            {
                var produto = _produtoService.CreateProduto(model);
                if (produto != null)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }



        public async Task<IActionResult> ProdutoUpdate(int id)
        {
            var produto = await _produtoService.FindById(id);
            if (produto != null)
            {
                return View(produto);
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> ProdutoUpdate(ProdutoModel model)
        {
            if (ModelState.IsValid)
            {
                var produto = _produtoService.UpdateProduto(model);
                if (produto != null)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }


        public async Task<IActionResult> ProdutoDelete(int id)
        {
            var produto = await _produtoService.FindById(id);
            if (produto != null)
            {
                return View(produto);
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> ProdutoDelete(ProdutoModel model)
        {
            var produto = await _produtoService.DeleteProduto(model.Id);
            if (produto)
            {
                return RedirectToAction(nameof(Index));
            }


            return View(model);
        }
    }
}
