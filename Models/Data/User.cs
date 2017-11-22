using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreServer.Models;

namespace DotnetCoreServer.Models
{
    public class User
    {
        public long UserID { get; set; }
        public string FacebookID{ get; set; }
        public string FacebookName{ get; set; }
        public string FacebookPhotoURL{ get; set; }
        public string FacebookAccessToken{ get; set; }
        public string AccessToken{ get; set; }
        public DateTime CreatedAt{ get; set; }
        public int Level{ get; set; }
        public int Experience{ get; set; }
        public int MaxExperience{ get; set; }
        public string Name{ get; set; }
        public int Money { get; set; }
        public int Str{ get; set; }
        public int Int{ get; set; }
        public int Con{ get; set; }
        public int StatPoint{ get; set; }
        public int xPos{ get; set; }
        public int yPos{ get; set; }
        public int zPos{ get; set; }
        public int Dex{ get; set; }
    }
}
