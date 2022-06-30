using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Exsist
{
    public static class FileExsist
    {
        public static bool IsExsist(this IFormFile formFile , int mb)
        {
            return formFile.ContentType.Contains("image") && formFile.Length < mb * 1024 * 1024;
        }
    }
}
