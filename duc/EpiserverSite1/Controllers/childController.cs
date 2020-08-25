using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;

namespace EpiserverSite1.Controllers
{
    public class childController : PageController<child>
    {
        public ActionResult Index(child currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var repo = ServiceLocator.Current.GetInstance<IContentLoader>();


            // Load all article pages that are direct children to the current page.
            var pages = repo.Get<child>(currentPage.ContentLink);

            ViewBag.item = pages;

            // TODO: Add filter to hide unpublished pages and apply access control. 

            

            return View(currentPage);
        }
    }
}