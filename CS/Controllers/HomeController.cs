using System.Web.Mvc;

namespace GridViewEditHotKeyMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(Invoice.GetData());
        }

        public ActionResult GridViewAddNewPartial(Invoice model) {
            // Update the underlying datasource here
            // ...
            return PartialView("GridViewPartial", Invoice.GetData());
        }
    }
}
