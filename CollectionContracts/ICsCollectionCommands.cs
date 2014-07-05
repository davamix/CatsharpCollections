using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionContracts;

namespace CatsharpCollections.Contracts
{
	public interface ICsCollectionCommands<T> where T:ICsItem
	{
		void Save(T item);
	}
}
