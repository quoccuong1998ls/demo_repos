using EpiserverSite1.Models.Pages;
using System;
using System.Collections.Generic;

namespace EpiserverSite1.Models.ViewModels
{

    public class esportViewModel
    {
       public IEnumerable<child> listPage { get; set; }
       public IEnumerable<child> listchild { get; set; }
       public child CurrentPage { get; set; }
    }
}