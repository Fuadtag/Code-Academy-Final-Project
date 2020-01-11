using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Helpers
{
    public class FileManager
    {
        private IWebHostEnvironment webHostEnvironment;
        public FileManager(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }
        public string Upload(IFormFile file, string allowedTypes = "image/png|image/jpeg|image/gif", int maxSize = 4096)
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
            if (file == null)
            {
                string fileName = "noimage.png";
                return fileName;
            }
            if (file.Length / 4096 > maxSize)
            {
                throw new Exception("File size max be 4096kb");
            }
            if (!allowedTypes.Split('|').Contains(file.ContentType))
            {
                throw new Exception("File type is not acceptable");
            }
            string filename = "Uploads/" + CreatePath() + "/" + Guid.NewGuid().ToString() + "-" + file.FileName;
            string filePath = Path.Combine(UploadPath, filename);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            file.CopyToAsync(fs);
            fs.Close();

            return filename;
        }
        public void Delete(string filename)
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");
            if (string.IsNullOrEmpty(filename))
            {
                throw new NullReferenceException("Filename cannot be null");
            }


            if (!File.Exists(Path.Combine(UploadPath, filename)))
            {
                throw new Exception("File doesnt exists");
            }


            File.Delete(Path.Combine(UploadPath, filename));
        }
        private string CreatePath()
        {
            string UploadPath = Path.Combine(webHostEnvironment.WebRootPath, "images");




            return UploadPath;
        }

    }
}
