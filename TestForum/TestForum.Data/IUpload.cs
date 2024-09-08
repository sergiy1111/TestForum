using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForum.Data
{
    public interface IUpload
    {
        Task<string> UploadImageAsync(IFormFile file, string fileName, ImageType type);
    }
    public enum ImageType
    {
        Forum,
        Profile
    }
}
