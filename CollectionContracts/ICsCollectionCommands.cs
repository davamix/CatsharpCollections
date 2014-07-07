using CollectionContracts;

namespace CatsharpCollections.Contracts
{
	public interface ICsCollectionCommands<T> where T:ICsItem
	{
		void Save(T item);
	}
}
