using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services
{
    // SRP: Handles only Blog-related data operations
    // DIP: Depends on abstractions, not concrete classes
    public class BlogService : IBlogService
    {
        private readonly BlogContext _context;

        public BlogService(BlogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await _context.BlogPosts.AsNoTracking().ToListAsync();
        }

        public async Task AddAsync(BlogPost post)
        {
            _context.BlogPosts.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
