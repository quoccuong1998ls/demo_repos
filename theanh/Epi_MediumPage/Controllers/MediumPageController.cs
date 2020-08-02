using System.Web.Mvc;
using EPiServer;
using EPiServer.Web.Mvc;
using Epi_MediumPage.Models.Pages;
using Epi_MediumPage.Models.ViewModels;
using System;
using EPiServer.Web;

namespace Epi_MediumPage.Controllers
{
    public class MediumPageController : PageControllerBase<MediumPage>
    {
        public ActionResult Index(MediumPage currentPage)
        {

            var model = PageViewModel.Create(currentPage);
            return View(model);
        }


    }
}