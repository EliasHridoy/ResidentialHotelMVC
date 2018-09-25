using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Models;
using ResidentialHotelMVCWebApp.Models.ViewModels;

namespace ResidentialHotelMVCWebApp.Gateway
{
    public class BookRoomGateway : CommonGateway
    {








        public string IsPossible(DateTime date, int roomid)
        {
            query = "SELECT * FROM BookRoomTable WHERE SelectedDate='" + date + "' AND RoomId='" + roomid + "'";

            Command = new SqlCommand(query,Connection);


            Connection.Open();

            Reader = Command.ExecuteReader();
            string name = "";
            if (Reader.Read())
            {
                 name = Reader["BookedBy"].ToString();
            }

            Connection.Close();

            return name;
        }












        public int Save(BookRoomModel bookRoom)
        {

            query = "INSERT INTO BookRoomTable VALUES(@CategoryId, @RoomId,@SelectedDate, @BookedBy, @Address)";


            Command = new SqlCommand(query,Connection);
            Command.Parameters.AddWithValue("@CategoryId", bookRoom.CategoryId);
            Command.Parameters.AddWithValue("@RoomId", bookRoom.RoomId);
            Command.Parameters.AddWithValue("@SelectedDate", bookRoom.SelectDate);
            Command.Parameters.AddWithValue("@BookedBy", bookRoom.BookedBy);
            Command.Parameters.AddWithValue("@Address", bookRoom.Address);



            Connection.Open();

            int rowEffect = Command.ExecuteNonQuery();
            Connection.Close();

            return rowEffect;
        }









        public List<RoomViewModel> GetRoomByCategoryId(int categoryId)
        {
            query = "SELECT * FROM RoomInfoTable WHERE CategoryId=" + categoryId;

            Command = new SqlCommand(query, Connection);

            List<RoomViewModel> roomList = new List<RoomViewModel>();


            Connection.Open();
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                
                RoomViewModel room  = new RoomViewModel();
                room.Id = Convert.ToInt32(Reader["Id"]);
                room.RoomNo = Reader["RoomNo"].ToString();

                roomList.Add(room);
            }
            Reader.Close();
            Connection.Close();

            return roomList;
        }



    }
}