using Microsoft.AspNetCore.Http;

namespace ETicaretAPI.Application.Services.IFileService
{
    public interface IFileService
    {
        Task<List<(string fileName,string path)>> Uploadsync(string path,IFormFileCollection files);
        Task<bool> CopyFileAsync(string path,IFormFile file);
    }
}
