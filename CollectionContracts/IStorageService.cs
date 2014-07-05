﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionContracts;

namespace CatsharpCollections.Contracts
{
	public interface IStorageService<T> where T:ICsItem
	{
		IList<T> GetAll(string tableName);
		T GetById(string tableName, Guid id);
		IList<T> GetBy(string tableName, Func<T, bool> predicate);
		void Save(string tableName, T item);
	}
}
