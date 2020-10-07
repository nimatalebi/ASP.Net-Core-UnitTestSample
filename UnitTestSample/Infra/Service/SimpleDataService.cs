using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTestSample.Infra.Abstract;
using UnitTestSample.Models;

namespace UnitTestSample.Infra.Service
{
    public class SimpleDataService : ISimpleDataService
    {
        public async Task<List<SimpleDataViewModel>> GetAll()
        {
            return new List<SimpleDataViewModel>()
            {
                new SimpleDataViewModel()
                {
                    Category = "Category 1",
                    Title = "Title 1"
                },
                new SimpleDataViewModel()
                {
                    Category = "Category 2",
                    Title = "Title 2"
                }
            };
        }

        public async Task Create(SimpleDataViewModel model)
        {
            throw new NullReferenceException();
        }

        public async Task Delete(int id)
        {
            return;
        }
    }
}
