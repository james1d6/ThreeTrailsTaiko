using System.Web;
using System.Web.Optimization;

namespace ThreeTrailsTaiko
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/ttt.css"));
			bundles.Add(new ScriptBundle("~/Content/js").Include("~/Content/ttt.js"));
		}
	}
}
