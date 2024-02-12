using CRUDUsingAPI.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDUsingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ProductDbContext _db;

        public CategoryController(ProductDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var categories = _db.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet]
        [Route("{id?}")]
        public IActionResult GetById(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }

            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();

            return Created("defaultApi", category);
        }

        [HttpPut]
        public IActionResult Update(int id, Category category)
        {
            if(category != null && id == category.Id)
            {
                var cat = _db.Categories.Find(id);

                if(cat == null)
                {
                    return NotFound();
                }
                else
                {
                    cat.Name = category.Name;
                    _db.SaveChanges();

                    return Ok(cat);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var cat = _db.Categories.Find(id);
            if(cat != null)
            {
                _db.Categories.Remove(cat);
                _db.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
