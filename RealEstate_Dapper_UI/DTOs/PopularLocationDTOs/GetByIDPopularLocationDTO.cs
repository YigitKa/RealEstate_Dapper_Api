﻿using System;
namespace RealEstate_Dapper_UI.DTOs.PopularLocationDTOs
{
	public class GetByIDPopularLocationDTO
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public string ImageURL { get; set; }
    }
}

