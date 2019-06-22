namespace MotoGPCalendar.Domain.Entities
{
    class Circuit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public double Length { get; set; }
        public int CurvesNumber { get; set; }
        public double Width { get; set; }
        public double LongerStraight { get; set; }
        public double Record { get; set; }
    }
}
