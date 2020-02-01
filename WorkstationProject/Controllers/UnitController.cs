using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WorkstationProject.Models;

namespace WorkstationProject.Controllers
{
  
    public class UnitController : Controller
    {
      
	
		public ActionResult Create()
		{
			return View();
		}

	}
}