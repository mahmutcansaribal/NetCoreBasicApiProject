using ApiProjectCamp.WebApi.Context;
using ApiProjectCamp.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectCamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetChef() 
        {
            var values = _context.Cheffs.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateChef(Cheff cheff) 
        {
            _context.Cheffs.Add(cheff);
            _context.SaveChanges();
            return Ok("Şef sisteme başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteChef(int id)
        {
            var value = _context.Cheffs.Find(id);
            _context.Cheffs.Remove(value);
            _context.SaveChanges();
            return Ok("Şef sistemden silindi");
        }
        [HttpGet("GetChefID")]
        public IActionResult GetChefID(int id)
        {
            return Ok(_context.Cheffs.Find(id));
        }
        [HttpPut]
        public IActionResult UpdateCheff(Cheff cheff) 
        {
            _context.Cheffs.Update(cheff);
            _context.SaveChanges();
            return Ok("Cheff Güncelleme başarılı");
        }
    }
}
