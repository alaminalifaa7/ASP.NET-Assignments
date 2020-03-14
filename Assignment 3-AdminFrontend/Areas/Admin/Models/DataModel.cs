
using Microsoft.Extensions.Configuration;
using Product.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSkill.LibrarySystem.Web.Areas.Admin.Models
{
    public class DataModel 
    {
        private readonly IDataService _dataService;
        public DataModel()
        {
            _dataService = new DataService();
        }

        internal object GetBooks(DataTablesAjaxRequestModel tableModel)
        {
            var data = _dataService.GetBooks(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Id","Name", "Price","Description"}));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                               record.Id.ToString(),
                                record.Name,
                                record.Price.ToString(),
                                record.Description     
                        }
                    ).ToArray()

            };
        }
    }
}
