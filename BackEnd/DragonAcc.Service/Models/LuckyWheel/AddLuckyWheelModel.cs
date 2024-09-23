﻿using Microsoft.AspNetCore.Http;

namespace DragonAcc.Service.Models.LuckyWheel
{
    public class AddLuckyWheelModel
    {
        public string? Prize { get; set; }
        public IFormFile? File { get; set; }
        public string? Image { get; set; }
        public float? Probability { get; set; }
    }
}
