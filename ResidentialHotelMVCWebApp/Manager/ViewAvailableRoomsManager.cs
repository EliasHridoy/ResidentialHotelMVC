using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Gateway;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Manager
{
    public class ViewAvailableRoomsManager
    {

        private ViewAvailableRoomsGateway viewAvailableRoomsGateway;

        public ViewAvailableRoomsManager()
        {
            viewAvailableRoomsGateway = new ViewAvailableRoomsGateway();
        }







        public List<ViewAvailableRoomsViewModel> ViewAvailableList(DateTime date)
        {


            return viewAvailableRoomsGateway.ViewAvailableList(date);
        }






    }
}