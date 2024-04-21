namespace Web_music_feb_jun2024.Models
{
    public class InstrumentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InstrumentClass? Parent { get; set; }
    }
}
