﻿using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile, string folder)
        {
            string guid = Guid.NewGuid().ToString();
            string file = guid + ".jpg";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\" + folder, file);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }

            return "~/img/" + folder + "/" + file;
        }
    }
}
