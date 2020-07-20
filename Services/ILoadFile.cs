using LoadPreFileWebApp.DTOS;
using LoadPreFileWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadPreFileWebApp.Services
{
    public interface ILoadFile
    {
        IEnumerable<ResultsLog> LoadFile(FileNameDTO filepath);
    }
}
