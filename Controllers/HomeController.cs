using System.Web.Mvc;

namespace prefecture_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("Home/Registration");
        }

        public ActionResult Registration()
        {
            Next();
            return View();
        }
        
        

        private void Next()
        {
            var registration = RegistrationSingleton.GetInstance().next();
            
            ViewBag.FrRegistration = new FrenchRegistration(registration);
            ViewBag.EsRegistration = new SpanishRegistration(registration);
            ViewBag.EnRegistration = new EnglishRegistration(registration);
        }

        
        public void OnPost()
        {
            Next();
        }
    }
}