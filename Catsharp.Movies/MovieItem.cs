﻿using System;
using CollectionContracts;

namespace Catsharp.Movies
{
    public class MovieItem : ICsItem
    {
	    public Guid Id { get; private set; }

	    public string Title { get; set; }
		public int Year { get; set; }
		public int Length { get; set; }

	    public MovieItem()
	    {
		    Id = Guid.NewGuid();
	    }
    }
}
