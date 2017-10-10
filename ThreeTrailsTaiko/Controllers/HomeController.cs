using System.Web.Mvc;
using ThreeTrailsTaiko.ApplicationCore;
using ThreeTrailsTaiko.Contracts.Repositories;

namespace ThreeTrailsTaiko.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//var slideShow = IoC.GetInstance<ISlideShow>();
			var slideShowRepository = IoC.GetInstance<ISlideShowRepository>();
			var slideShow = slideShowRepository.GetSlideShowByAlias("Test1");


			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}