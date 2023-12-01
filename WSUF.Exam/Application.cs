namespace WSUF.Exam
{
    public class Application
    {
        private readonly SolarSystemService _solarSystemService;

        public Application(SolarSystemService solarSystemService) 
        {
            _solarSystemService = solarSystemService;
        }

        public void Run() 
        {
            // Call the SolarSystemService's methods from here
            _solarSystemService.WriteAllBodiesNameToConsole();
        }
    }
}
