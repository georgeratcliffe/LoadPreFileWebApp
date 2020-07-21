using LoadPreFileWebApp.DTOS;
using LoadPreFileWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LoadPreFileWebApp.Services
{
    public class LoadFileService : ILoadFile
    {
        private AppDbContext _context;
        private readonly ILogger<LoadFileService> _logger;

        public LoadFileService(AppDbContext context, ILogger<LoadFileService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IEnumerable<ResultsLog> LoadFile(FileNameDTO filepath)
        {
                _logger.LogInformation($"LoadFile call for {filepath.FileName} made to database");
                _context.Database.SetCommandTimeout(3000);

                IEnumerable<ResultsLog> results = _context.ResultsLog.FromSqlRaw<ResultsLog>($"dbo.ImportPreFile {filepath.FileName}").ToList();
                return results;
        }
    }
}
