using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Gateway
{
    public class ViewAvailableRoomsGateway: CommonGateway
    {


        public List<ViewAvailableRoomsViewModel> ViewAvailableList(DateTime date)
        {
            query = "SELECT        RoomInfoTable.RoomNo, CategoryTable.Category, BookRoomTable.SelectedDate " +
                    "FROM            RoomInfoTable INNER JOIN CategoryTable ON" +
                    " RoomInfoTable.CategoryId = CategoryTable.Id LEFT JOIN BookRoomTable" +
                    " ON RoomInfoTable.Id = BookRoomTable.RoomId AND " +
                    "CategoryTable.Id = BookRoomTable.CategoryId WHERE SelectedDate IS NULL OR (NOT SelectedDate = '"+date+"')";




            Command = new SqlCommand(query,Connection);


            List<ViewAvailableRoomsViewModel> roomList = new List<ViewAvailableRoomsViewModel>();

            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                ViewAvailableRoomsViewModel room = new ViewAvailableRoomsViewModel();
                room.RoomNo = Reader["RoomNo"].ToString();
                room.Category = Reader["Category"].ToString();

                roomList.Add(room);
            }
            Connection.Close();


            return roomList;
        }
    }
}