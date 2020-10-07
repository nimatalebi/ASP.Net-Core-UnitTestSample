using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestSample.Models;

namespace UnitTestSample.Infra.Abstract
{
    public interface ISimpleDataService
    {
        Task<List<SimpleDataViewModel>> GetAll();

        Task Create(SimpleDataViewModel model);

        Task Delete(int id);
    }
}
