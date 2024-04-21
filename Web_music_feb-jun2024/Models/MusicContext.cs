using Microsoft.EntityFrameworkCore;

namespace Web_music_feb_jun2024.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Instrument> Instruments { get; set; } = null!;
        public DbSet<InstrumentClass> InstrumentClasses { get; set; } = null!;
    }
}
