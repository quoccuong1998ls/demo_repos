using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using EpiserverSite1.Models.Media;

namespace EpiserverSite1.Controllers
{
    public class ImageFileController : PartialContentController<ImageFile>
    {
		private readonly UrlResolver _urlResolver;

		public ImageFileController(UrlResolver urlResolver)
		{
			_urlResolver = urlResolver;
		}

		/// <summary>
		/// The index action for the image file. Creates the view model and renders the view.
		/// </summary>
		/// <param name="currentContent">The current image file.</param>
		public override ActionResult Index(ImageFile currentContent)
		{
			var model = new ImageViewModel
			{
				Url = _urlResolver.GetUrl(currentContent.ContentLink),
				Name = currentContent.Name
			};

			return PartialView(model);
		}
	}
}