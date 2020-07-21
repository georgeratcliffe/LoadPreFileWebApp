using LoadPreFileWebApp.DTOS;
using LoadPreFileWebApp.Models;
using System.Collections.Generic;

namespace LoadPreFileWebApp.Services
{
    public interface ILoadFile
    {
        IEnumerable<ResultsLog> LoadFile(FileNameDTO filepath);
    }
}
