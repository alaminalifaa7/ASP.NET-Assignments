using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Product.Framework
{
    public class DataService : IDataService
    {
        IList<Data> _dummyData;

        public DataService()
        {
            _dummyData = new List<Data>();

            for (var i = 0; i < 100; i++)
            {
                _dummyData.Add(new Data
                {
                    Id = i,
                    Name = "Name " + i,
                    Price = "free",
                    Description = "Watches"+i
                    
                });
            }
        }
        public (IList<Data> records, int total, int totalDisplay) GetBooks(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var filteredData = _dummyData.Where(x => x.Name.Contains(searchText)
            || x.Description.Contains(searchText));

            var filteredDataCount = filteredData.Count();
            var totalData = _dummyData.Count();

            var filteredDataList = filteredData.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return (filteredDataList, totalData, filteredDataCount); 
        }
    }
}
