using Blogpost.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogpost.Repository
{
   public interface IBlogRepository
    {
        void CreateBlog(blg body);
        Task<IEnumerable> GetallBlogs();
        Task<blg> GetBlockbyId(int id);
        Task<blg> Deletebyid(int id);
        Task<blg> UpdateBlog(int id, blg body);
          

    }
}
