using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CollectionContracts
{
    public interface ICsCollectionQueries<T> where T:ICsItem
    {
		Guid Id { get; }

		IList<T> GetAll();
		T GetById(Guid id);
		IList<T> GetBy(Func<T, bool> predicate);

    }
}
