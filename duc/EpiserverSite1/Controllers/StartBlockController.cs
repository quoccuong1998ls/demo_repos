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
    public class StartBlockController : BlockController<StartBlock>
    {
        public override ActionResult Index(StartBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
