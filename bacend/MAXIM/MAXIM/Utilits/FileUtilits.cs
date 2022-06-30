using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Utilits
{
    public static class FileUtilits
    {
        public static async Task<string> FileCreate(this IFormFile form, string root, string file)
        {
            string Filesteram = Guid.NewGuid() + form.FileName;

            string path = Path.Combine(root, file);

            string allpath = Path.Combine(Filesteram, path);

            using (FileStream fileStream = new FileStream(allpath,FileMode.Create))
            {
                await form.CopyToAsync(fileStream);
            }

            return Filesteram;
        }
    }
}
