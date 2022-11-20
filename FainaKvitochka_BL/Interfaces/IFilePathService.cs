using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Interfaces
{
    public interface IFilePathService
    {
        Task<IEnumerable<FilePath>> GetAllFilePaths();
        Task<FilePath> GetByIdFilePath(Guid id);
        Task<bool> DeleteByIdFilePath(Guid id);
        Task<bool> UpdateFilePath(FilePath filePath);
        Task<Guid> AddFilePath(FilePath filePath);
    }
}
