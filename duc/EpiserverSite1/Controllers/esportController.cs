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
    public class esportController : PageController<esport>
    {
        public ActionResult Index(esport currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
            // * you can pass the page type for simpler templates */
            //var repository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();
            //ContentReference pageLink = ContentReference.StartPage;

            //IEnumerable<PageData> pages = repository.GetChildren<PageData>(pageLink);


            //ViewBag.children = pages;
            //return View(currentPage);
            var repo = ServiceLocator.Current.GetInstance<IContentLoader>();

            var filter = new FilterContentForVisitor();
            // Load all article pages that are direct children to the current page.
            var pages = repo.GetChildren<child>(currentPage.ContentLink)
                .Where(page => !filter.ShouldFilter(page)); 


            // TODO: Add filter to hide unpublished pages and apply access control. 

            var model = new esportViewModel
            {
                
                listPage = pages
            };
            
            return View(model);
            //return View(currentPage);
        }
    }
}