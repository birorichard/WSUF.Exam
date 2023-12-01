using WSUF.Exam.Client;

namespace WSUF.Exam
{
    public class SolarSystemService
    {
        private readonly SolarSystemClient _solarSystemClient;

        public SolarSystemService(SolarSystemClient solarSystemClient)
        {
            _solarSystemClient = solarSystemClient;
        }

        public void WriteAllBodiesNameToConsole()
        {
            var bodies = _solarSystemClient.GetAllBodies();

            if (bodies != null)
            {
                Console.WriteLine(string.Join("\n", bodies.Where(x => x.IsPlanet).Select(x => x.EnglishName).ToList()));
            }
        }
    }
}
