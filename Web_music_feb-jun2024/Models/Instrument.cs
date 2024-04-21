namespace Web_music_feb_jun2024.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public InstrumentClass Class { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
        public string Img { get; set; }
        public string Articul { get; set; }
    }
}
