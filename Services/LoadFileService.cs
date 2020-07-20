using LoadPreFileWebApp.DTOS;
using LoadPreFileWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadPreFileWebApp.Services
{
    public class LoadFileService : ILoadFile
    {
        private AppDbContext _context;

        public LoadFileService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ResultsLog> LoadFile(FileNameDTO filepath)
        {
            _context.Database.SetCommandTimeout(3000);

            IEnumerable<ResultsLog> results = _context.ResultsLog.FromSqlRaw<ResultsLog>($"dbo.ImportPreFile {filepath.FileName}").ToList();
            return results;
        }
    }
}
