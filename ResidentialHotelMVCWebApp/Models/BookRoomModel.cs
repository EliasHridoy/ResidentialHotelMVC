using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResidentialHotelMVCWebApp.Models
{
    public class BookRoomModel
    {

        [Required(ErrorMessage = "Please Select Category")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please Select Room")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Please Select Room")]
        public DateTime SelectDate { get; set; }

        [Required(ErrorMessage = "Please Enter a Name")]
        public string BookedBy { get; set; }
        public string Address { get; set; }
    }
}