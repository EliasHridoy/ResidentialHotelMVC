using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResidentialHotelMVCWebApp.Models
{
    public class RoomInfoModel
    {

        [Required(ErrorMessage = "Please Select Room")]
        public string RoomNo { get; set; }
        [Required(ErrorMessage = "Please Select Category")]
        public int CategoryId { get; set; }
        public string Description { get; set; }

    }
}