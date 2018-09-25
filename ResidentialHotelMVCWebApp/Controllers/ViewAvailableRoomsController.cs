using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResidentialHotelMVCWebApp.Manager;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Controllers
{
    public class ViewAvailableRoomsController : Controller
    {
        //
        // GET: /ViewAvailableRooms/


        private ViewAvailableRoomsManager viewAvailableRoomsManager;

        public ViewAvailableRoomsController()
        {
            viewAvailableRoomsManager = new ViewAvailableRoomsManager();
        }



        [HttpGet]

        public ActionResult Show()
        {


            return View();
        }
        [HttpPost]

        public ActionResult Show(DateTime date)
        {
            if (date != null)
            {
                ViewBag.rooms = viewAvailableRoomsManager.ViewAvailableList(date);
                ViewBag.message = "";
            }
            else
            {
                ViewBag.message = "Select Date";
            }

            return View();
        }
    }
}