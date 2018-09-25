using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Gateway;
using ResidentialHotelMVCWebApp.Models;

namespace ResidentialHotelMVCWebApp.Manager
{
    public class RoomInfoManager
    {

        private RoomInfoGateway roomInfoGateway;

        public RoomInfoManager() // Constructor
        {
            roomInfoGateway = new RoomInfoGateway();
        }


        public bool IsRoomExists(string roomNo)
        {
            return roomInfoGateway.IsRoomExists(roomNo);
        }

        public string Save(RoomInfoModel roomInfo)
        {
            int rowEffect = roomInfoGateway.Save(roomInfo);

            if (rowEffect > 0)
            {
                return "Save Successful";
            }
            else
            {
                return "Save Faild";
            }
        }

        public List<CategoryModel> GetAllCategory()
        {
            return roomInfoGateway.GetAllCategory();
        }

    }
}