using FainaKvitochka_BL.Interfaces;
using FainaKvitochka_DAL.Interfaces;
using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_BL.Services
{
    public class FilePathService : IFilePathService
    {
        private readonly IGenericRepository<FilePath> _filePathRepository;

        public FilePathService(IGenericRepository<FilePath> filePathRepository)
        {
            _filePathRepository = filePathRepository;
        }

        public async Task<Guid> AddFilePath(FilePath filePath)
        {
            return await _filePathRepository.Add(filePath);
        }

        public async Task<bool> DeleteByIdFilePath(Guid id)
        {
            return await _filePathRepository.DeleteById(id);
        }

        public async Task<IEnumerable<FilePath>> GetAllFilePaths()
        {
            return await _filePathRepository.GetAll();
        }

        public async Task<FilePath> GetByIdFilePath(Guid id)
        {
            return await _filePathRepository.GetById(id);
        }

        public async Task<bool> UpdateFilePath(FilePath filePath)
        {
            return await _filePathRepository.Update(filePath);
        }
    }
}
