using Microsoft.AspNetCore.Mvc;
using TestForum.Data;
using TestForum.Data.Models;
using TestForum.Models.Forum;
using TestForum.Models.Post;
using TestForum.Models.Search;

namespace TestForum.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPost _postService;
        
        public SearchController(IPost postService)
        {
            _postService = postService;
        }
        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.GetFilteredPosts(searchQuery);

            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());

            var postListing = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                DatePosted = post.Created,
                Title = post.Title,
                RepliesCount = post.Replies.Count(),
                Forum = BuildingForumListing(post)
            });

            var model = new SearchResultModel
            {
                Posts = postListing,
                SearchQuery = searchQuery,
                EmptySearchResulr = areNoResults
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }

        private ForumListingModel BuildingForumListing(Post post)
        {
            var forum = post.Forum;

            return new ForumListingModel
            {
                Id = forum.Id,
                ImageUrl = forum.ImageUrl,
                Title = forum.Title,
                Description = forum.Description
            };
        }

    }
}
