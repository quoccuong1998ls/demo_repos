using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverSite1.Models.Blocks;

namespace EpiserverSite1.Controllers
{
    public class ContentBlockController : BlockController<ContentBlock>
    {
        public override ActionResult Index(ContentBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
