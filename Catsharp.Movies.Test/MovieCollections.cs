using System;
using System.Collections.Generic;
using CatsharpCollections.Common;
using NUnit.Framework;

namespace Catsharp.Movies.Test
{
	[TestFixture]
	public class MovieCollections
	{
		private static MemoryStorageService<MovieItem> _service;
		private static MovieCollection _collection;

		[SetUp]
		public void Init()
		{
			IocConfiguration.Configure();
			_service = new MemoryStorageService<MovieItem>();
			_collection = new MovieCollection(_service);

			_service.PopulateDataSource(
				"Movies",
				new List<MovieItem>
				{
					new MovieItem
					{
						Title = "Ice Age",
						Length = 99,
						Year = 2007
					},
					new MovieItem
					{
						Title = "Cars",
						Length = 102,
						Year = 2009
					},
					new MovieItem
					{
						Title = "Wall-e",
						Length = 104,
						Year = 2010
					}
				});
		}

		[Test]
		public void GetAll()
		{
			Assert.AreEqual(3, _collection.GetAll().Count);
		}

		[Test]
		public void GetBy()
		{
			Func<MovieItem, bool> predicate = item => item.Length > 100;

			Assert.AreEqual(2, _collection.GetBy(predicate).Count);
		}

		[Test]
		public void Save()
		{
			var item = new MovieItem
			           {
				           Title = "Monsters Inc.",
				           Length = 95,
				           Year = 2009
			           };

			_collection.Save(item);

			CollectionAssert.Contains(_collection.GetAll(), item);
		}
	}
}
