using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogpost.Data;
using Blogpost.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogpost.Repository
{
    public class BlogRepositoryImpl : IBlogRepository
    {
        private readonly BlogDbContext _context;
        public BlogRepositoryImpl(BlogDbContext context)
        {
            _context = context;
        }

        public void CreateBlog(blg body)
        {
            _context.blgs.Add(body);
            _context.SaveChanges();
        }

        public async Task<blg> Deletebyid(int id)
        {
            var blg = await _context.blgs.FindAsync(id);

            if (blg == null) return null;
           

            _context.blgs.Remove(blg);
            await _context.SaveChangesAsync();
            return blg;
        }

        public async Task<IEnumerable> GetallBlogs()
        {
            var blog = await _context.blgs.ToListAsync();
            return blog;
        }

        public async Task<blg> GetBlockbyId(int id)
        {
            var blg = await _context.blgs.FindAsync(id);

            return blg;
        }

        public async Task<blg> UpdateBlog(int id, blg body)
        {
            _context.Entry(body).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return body;
        }
    }
}
