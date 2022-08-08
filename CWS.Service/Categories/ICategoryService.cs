
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CWS.Service.categories
{
    public interface ICategoryService
    {
        Task<List<string>> GetCategories();
    }
}
