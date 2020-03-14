using Product.Framework;
using System.Collections.Generic;

namespace Product.Framework
{
    public interface IDataService
    {
        (IList<Data> records, int total, int totalDisplay) GetBooks(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
    }
}