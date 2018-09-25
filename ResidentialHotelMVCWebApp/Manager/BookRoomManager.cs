using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Gateway;
using ResidentialHotelMVCWebApp.Models;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Manager
{
    public class BookRoomManager
    {

        private BookRoomGateway bookRoomGateway;

        public BookRoomManager()
        {
            bookRoomGateway = new BookRoomGateway();
        }





        public string IsPossible(DateTime date, int roomid)
        {
            return bookRoomGateway.IsPossible(date, roomid);
        }




        public string Save(BookRoomModel bookRoom)
        {

            int rowEffect = bookRoomGateway.Save(bookRoom);


            if (rowEffect > 0)
            {
                return "Save Successful";
            }
            else
            {
                return "Save Faild";
            }
        }



        public List<RoomViewModel> GetRoomByCategoryId(int categoryId)
        {
            return bookRoomGateway.GetRoomByCategoryId(categoryId);
        }
    }
}