using Blog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogPost>> GetAllAsync();
        Task AddAsync(BlogPost post);
    }
}
