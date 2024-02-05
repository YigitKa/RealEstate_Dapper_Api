﻿using System;
namespace RealEstate_Dapper_UI.DTOs.ProductDTOs
{
	public class ResultProductDTO
    {
        public int productID { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryName { get; set; }
        public string type { get; set; }
        public string coverImage { get; set; }
        public string address { get; set; }
    }
}

