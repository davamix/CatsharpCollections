using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatsharpCollections.Contracts;
using CollectionContracts;

namespace CatsharpCollections.Common
{
    public class MemoryStorageService<T> : IStorageService<T> where T:ICsItem
    {
	    private Dictionary<string, List<T>> _myDataSource;

	    public MemoryStorageService()
	    {
		    _myDataSource = new Dictionary<string, List<T>>();
	    }

	    public void Save(string tableName, T item)
	    {
		    _myDataSource[tableName].Add(item);
	    }

	    public void PopulateDataSource(string tableName, List<T> data)
	    {
		    _myDataSource.Add(tableName, data);
	    }

	    public IList<T> GetAll(string tableName)
	    {
		    return _myDataSource[tableName];
	    }

	    public T GetById(string tableName, Guid id)
	    {
		    return _myDataSource[tableName].SingleOrDefault(x => x.Id == id);
	    }

	    public IList<T> GetBy(string tableName, Func<T, bool> predicate)
	    {
		    return _myDataSource[tableName].Where(predicate).ToList();
	    }
    }
}
