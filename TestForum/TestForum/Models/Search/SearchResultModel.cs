using TestForum.Models.Post;

namespace TestForum.Models.Search
{
    public class SearchResultModel
    {
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptySearchResulr {  get; set; }

    }
}
