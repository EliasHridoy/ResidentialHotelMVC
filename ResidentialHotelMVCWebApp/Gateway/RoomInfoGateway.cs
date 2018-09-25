using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ResidentialHotelMVCWebApp.Models;

namespace ResidentialHotelMVCWebApp.Gateway
{
    public class RoomInfoGateway: CommonGateway
    {




        public bool IsRoomExists(string roomNo)
        {
            query = "SELECT * FROM RoomInfoTable where RoomNo='"+roomNo+"' " ; 

            Command = new SqlCommand(query, Connection);

           
            Connection.Open();
            Reader = Command.ExecuteReader();

            bool check = Reader.HasRows;
           
            Reader.Close();
            Connection.Close();

            return check;
        }


        public int Save(RoomInfoModel roomInfo)
        {
            query = "INSERT INTO RoomInfoTable VALUES (@RoomNo,@CategoryId,@Description)";

            Command = new SqlCommand(query,Connection);

            Command.Parameters.AddWithValue("@RoomNo", roomInfo.RoomNo);
            Command.Parameters.AddWithValue("@CategoryId", roomInfo.CategoryId);
            Command.Parameters.AddWithValue("@Description", roomInfo.Description);

            Connection.Open();

            int rowEffect = Command.ExecuteNonQuery();
            Connection.Close();

            return rowEffect;
        }

        //-------------------------------------------------------------------------------------
        public List<CategoryModel> GetAllCategory()
        {
            query = "SELECT * FROM CategoryTable";

            Command = new SqlCommand(query,Connection);

            List<CategoryModel> categoryList = new List<CategoryModel>();
            
            Connection.Open();
            Reader = Command.ExecuteReader();


            while (Reader.Read())
            {
                CategoryModel category = new CategoryModel();
                category.Id = Convert.ToInt32(Reader["Id"]);
                category.Category = Reader["Category"].ToString();

                categoryList.Add(category);
            }
            Reader.Close();
            Connection.Close();

            return categoryList;
        }



    }
}