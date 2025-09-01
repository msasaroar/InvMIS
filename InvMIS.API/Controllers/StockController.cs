using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvMIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StockController : ControllerBase
    {
        private readonly IStockService _service;

        public StockController(IStockService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var stock = _service.GetById(id);
            if (stock == null) return NotFound();
            return Ok(stock);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Stock stock)
        {
            _service.Add(stock);
            return Ok(stock);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id, Stock stock)
        {
            if (id != stock.Id) return BadRequest();
            _service.Update(stock);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
