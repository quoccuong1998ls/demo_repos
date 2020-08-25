using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.UI.Report;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;

namespace EpiserverSite1.Controllers
{
    public class TestController : PageController<Test>
    {
        public ActionResult Index(Test currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var repository = ServiceLocator.Current.GetInstance<IContentRepository>();
            ContentReference pageLink = ContentReference.StartPage;
            IEnumerable<PageData> pages = repository.GetChildren<PageData>(pageLink);

            ////  
            //return pages;
            ViewBag.children = pages;
            
            return View();
        }
       
    }
}