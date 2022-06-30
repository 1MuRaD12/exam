using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }
        public string SubTitle { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
