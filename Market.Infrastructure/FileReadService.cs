using Market.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure
{
    public class FileReadService : IReadService
    {
        public async Task<byte[]> ReadAsync(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }


            return await File.ReadAllBytesAsync(path);

            //using (var reader = File.OpenText(path))
            //{
            //    return await reader.ReadToEndAsync();
            //}
        }
    }
}
