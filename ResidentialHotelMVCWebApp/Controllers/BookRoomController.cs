using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResidentialHotelMVCWebApp.Manager;
using ResidentialHotelMVCWebApp.Models;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Controllers
{
    public class BookRoomController : Controller
    {
        //
        // GET: /BookRoom/

        private RoomInfoManager roomInfoManager;
        private BookRoomManager bookRoomManager;

        public BookRoomController()
        {
            roomInfoManager = new RoomInfoManager();
            bookRoomManager = new BookRoomManager();
        }


        [HttpGet]
        public ActionResult Save()
        {
            ViewBag.categorys = roomInfoManager.GetAllCategory();

            return View();
        }
        //-----------------------------------------------------------------------------------//

        [HttpPost]
        public ActionResult Save(BookRoomModel bookRoom)
        {
            ViewBag.categorys = roomInfoManager.GetAllCategory();
            string name = IsPossible(bookRoom.SelectDate, bookRoom.RoomId);
            if ( name == "")
            {
                ViewBag.message = bookRoomManager.Save(bookRoom);
            }
            else
            {
                ViewBag.message = "This schedule is already booked by "+ name;
            }
            return View();
        }
        //-----------------------------------------------------------------------------------//
        public string IsPossible(DateTime date, int roomId)
        {
            return bookRoomManager.IsPossible(date, roomId);

        }




        //-----------------------------------------------------------------------------------//
        public JsonResult GetRoomByCategoryId(int categoryId)
        {
            List<RoomViewModel> roomsList = bookRoomManager.GetRoomByCategoryId(categoryId);
            JsonResult jsonResult = Json(roomsList);
            return jsonResult;
            

        }
    }
}