using MAXIM.DAL;
using MAXIM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Setting>> GetSettings()
        {
            List<Setting> settings = await _context.settings.ToListAsync();

            return settings;
        }
    }
}
