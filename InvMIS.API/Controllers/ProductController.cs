﻿using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvMIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]   // JWT required
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]  // Only Admin can create
        public async Task<IActionResult> Create(Product product)
        {
            await _productService.AddAsync(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]  // Only Admin can update
        public async Task<IActionResult> Update(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            await _productService.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]  // Only Admin can delete
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id);
            return NoContent();
        }
    }
}
