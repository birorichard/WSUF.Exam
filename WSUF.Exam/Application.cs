namespace WSUF.Exam
{
    public class Application
    {
        private readonly SolarSystemService _solarSystemService;

        public Application(SolarSystemService solarSystemService) 
        {
            _solarSystemService = solarSystemService;
        }

        /// <summary>
        /// Call the SolarSystemService's methods from here
        /// </summary>
        public void Run() 
        {
            _solarSystemService.WriteAllBodiesNameToConsole();

            Console.WriteLine("\n");
            Console.WriteLine("Bolygók gravitációs ereje:\n");

            _solarSystemService.WriteGravityToConsole();

        }
    }
}
