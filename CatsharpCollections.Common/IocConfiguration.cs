using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CatsharpCollections.Contracts;

namespace CatsharpCollections.Common
{
	public class IocConfiguration
	{
		public static IContainer Container { get; set; }

		public static void Configure()
		{
			var builder = new ContainerBuilder();

			builder.RegisterGeneric(typeof (MemoryStorageService<>)).As(typeof (IStorageService<>));


			builder.Build();
		}
	}
}
