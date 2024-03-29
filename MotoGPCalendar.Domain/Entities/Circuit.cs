﻿namespace MotoGPCalendar.Domain.Entities
{
    public class Circuit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int CurvesNumber { get; set; }
        public double LongestStraight { get; set; }
        public double Record { get; set; }
    }
}
