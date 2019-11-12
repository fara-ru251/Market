using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Market.Application.Interfaces
{
    public interface IReadService
    {
        Task<byte[]> ReadAsync(string path);
    }
}
