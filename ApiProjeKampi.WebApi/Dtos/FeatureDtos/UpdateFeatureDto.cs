﻿namespace ApiProjeKampi.WebApi.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string imageUrl { get; set; }
    }
}
