using StructureMap;

namespace ThreeTrailsTaiko.ApplicationCore
{
	public static class IoC
	{
		private static IContainer container = new Container(c =>
		{
			c.Scan(s =>
			{
				s.TheCallingAssembly();
				s.AssembliesFromApplicationBaseDirectory();
				//s.IncludeNamespace("ThreeTrailsTaiko");
				s.WithDefaultConventions();
			});
		});

		public static T GetInstance<T>()
		{
				return container.GetInstance<T>();
		}
	}

}
