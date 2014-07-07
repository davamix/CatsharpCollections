using System;
using System.Collections.Generic;
using CatsharpCollections.Contracts;
using CollectionContracts;

namespace Catsharp.Movies
{
	public class MovieCollection : ICsCollectionQueries<MovieItem>, ICsCollectionCommands<MovieItem>
	{
		private IStorageService<MovieItem> _service;
		private const string TABLE_NAME = "Movies";

		public Guid Id { get; private set; }

		public MovieCollection(IStorageService<MovieItem> service)
		{
			_service = service;
			Id = Guid.NewGuid();
		}

		public IList<MovieItem> GetAll()
		{
			return _service.GetAll(TABLE_NAME);
		}

		public MovieItem GetById(Guid id)
		{
			return _service.GetById(TABLE_NAME, id);
		}

		public IList<MovieItem> GetBy(Func<MovieItem, bool> predicate)
		{
			return _service.GetBy(TABLE_NAME, predicate);
		}

		public void Save(MovieItem item)
		{
			_service.Save(TABLE_NAME, item);
		}
	}
}
