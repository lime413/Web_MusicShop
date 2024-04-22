using Web_music_feb_jun2024.Models;

namespace Web_music_feb_jun2024.ViewModels
{
    public class CatalogViewModel
    {
        public int Id;
        public IEnumerable<InstrumentClass> instrumentClasses;
        public IEnumerable<Instrument>? instruments;
    }
}
