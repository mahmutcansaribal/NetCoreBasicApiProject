﻿namespace ApiProjectCamp.WebApi.Dtos.ContactDtos
{
    public class ResultConctactDto
    {
        public int ContactID { get; set; }
        public string ContactMapLocation { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactOpenHours { get; set; }
    }
}
