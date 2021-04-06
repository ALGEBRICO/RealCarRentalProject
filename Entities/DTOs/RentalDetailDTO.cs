﻿using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Entities.DTOs
{
    public class RentalDetailDTO:IDto
    {
        public int RentId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime RentStartTime { get; set; }
        public DateTime? RentEndTime { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
