using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForum.Data;

namespace TestForum.Service
{
    public class UploadService : IUpload
    {
        private readonly string _forumsBasePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "forums");
        private readonly string _profilesBasePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "profiles");

        public UploadService()
        {
            if (!Directory.Exists(_forumsBasePath))
            {
                Directory.CreateDirectory(_forumsBasePath);
            }

            if (!Directory.Exists(_profilesBasePath))
            {
                Directory.CreateDirectory(_profilesBasePath);
            }
        }

        public async Task<string> UploadImageAsync(IFormFile file, string fileName, ImageType type)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("Invalid file.");
            }

            var fileExtension = Path.GetExtension(file.FileName);
            var fullFileName = $"{fileName}{fileExtension}";
            string basePath = type == ImageType.Forum ? _forumsBasePath : _profilesBasePath;
            var filePath = Path.Combine(basePath, fullFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var relativePath = type == ImageType.Forum ? "forums" : "profiles";
            return $"/images/{relativePath}/{fullFileName}";
        }
    }
}
