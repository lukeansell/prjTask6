namespace prjTask6
{
    internal class Program
    {
        public delegate void BandAnnouncementDelegate(Band band);
        public delegate void StagePerformanceDelegate();
        static void Main(string[] args)
        {
            FestivalPlanner fp = new();
            BandAnnouncementDelegate registerBand = new BandAnnouncementDelegate(fp.AddBand);
            Band one = new("First Band", "some genre", "10:00");
            Band two = new("Another Band", "another genre", "12:00");
            //StagePerformanceDelegate registerPerformance = new StagePerformanceDelegate();
            Console.WriteLine(fp.ToString());
        }
    }
}
