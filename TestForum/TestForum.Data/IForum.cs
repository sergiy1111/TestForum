using System.Collections.Generic;
using TestForum.Data.Models;

namespace TestForum.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        IEnumerable<ApplicationUser> GetAllActiveUsers(int id);
        bool HasRecentPost(int id);
    }
}
