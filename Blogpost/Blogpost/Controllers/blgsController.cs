using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blogpost.Data;
using Blogpost.Models;
using Blogpost.Repository;

namespace Blogpost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blgsController : ControllerBase
    {
        private readonly IBlogRepository _repo;

        public blgsController( IBlogRepository repo)
        {
            _repo = repo;
        }

        // GET: api/blgs
        [HttpGet]
        public async Task<IActionResult> Getblgs()
        {
            var ab = await _repo.GetallBlogs();
            return Ok(ab);
        }

        // GET: api/blgs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getblg([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blg =await _repo.GetBlockbyId(id);


            if (blg == null)
            {
                return NotFound();
            }

            return Ok(blg);
        }

       

        // POST: api/blgs
        [HttpPost]
        public async Task<IActionResult> Postblg([FromBody] blg blg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repo.CreateBlog(blg);
            

            return CreatedAtAction("Getblg", new { id = blg.id }, blg);
        }

        // DELETE: api/blgs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteblg([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


          var blg= await  _repo.Deletebyid(id);

            if (blg == null) return NotFound("no blgo with this id ");
            return Ok(blg);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlog(int id, blg item)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

            await _repo.UpdateBlog(id, item);

            return Ok("updated ");
        }


    }
}