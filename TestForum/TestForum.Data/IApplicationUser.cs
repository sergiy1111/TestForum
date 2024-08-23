using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForum.Data.Models;

namespace TestForum.Data
{
    public interface IApplicationUser
    {
        ApplicationUser GetById(string id);
        IEnumerable<ApplicationUser> GetAll();

        Task SetUserProfileImage(string id, Uri uri); 
        Task IncrementRating (int id, Type type);
    }
}
