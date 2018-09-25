using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResidentialHotelMVCWebApp.Manager;
using ResidentialHotelMVCWebApp.Models;

namespace ResidentialHotelMVCWebApp.Controllers
{
    public class RoomInfoController : Controller
    {
        //
        // GET: /RoomInfo/

        private RoomInfoManager roomInfoManager;

        public RoomInfoController()
        {
            roomInfoManager = new RoomInfoManager();
        }


        [HttpGet]
        public ActionResult Save()
        {

            ViewBag.categorys = roomInfoManager.GetAllCategory();

            return View();
        }
        
        
        [HttpPost]
        public ActionResult Save(RoomInfoModel roomInfo)
        {

            ViewBag.categorys = roomInfoManager.GetAllCategory();
            if (roomInfoManager.IsRoomExists(roomInfo.RoomNo) != true)
            {
                ViewBag.message = roomInfoManager.Save(roomInfo);
            }
            else
            {
                ViewBag.message = "Room Already Exists";
            }

            return View();
        }


        
    }
}