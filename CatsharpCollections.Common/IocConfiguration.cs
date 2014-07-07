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
