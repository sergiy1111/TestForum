using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForum.Data;
using TestForum.Data.Models;

namespace TestForum.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(post => post.User)
                .Include(post => post.Replies)
                    .ThenInclude(reply => reply.User)
                    .Include(post => post.Forum);

        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(post => post.Id == id)
                .Include(post => post.User)
                .Include(post => post.Replies)
                    .ThenInclude(reply => reply.User)
                .Include(post => post.Forum)
                .First();
        }

        public IEnumerable<Post> GetFilteredPosts(int id,string searchQuerty)
        {
            var forum = _context.Forums.Find(id);

            return String.IsNullOrEmpty(searchQuerty) 
                ? forum.Posts 
                : forum.Posts.Where(post => post.Title.Contains(searchQuerty) || post.Content.Contains(searchQuerty));
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuerty)
        {
            return GetAll().Where(post => post.Title.Contains(searchQuerty) || post.Content.Contains(searchQuerty));
        }

        public IEnumerable<Post> GetLatestPosts(int number)
        {
            return GetAll().OrderByDescending(post => post.Created).Take(number);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums
                .Where(forum => forum.Id == id)
                .First()
                .Posts;
        }
    }
}
