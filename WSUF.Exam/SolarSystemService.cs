using WSUF.Exam.Client;
using WSUF.Exam.Model;

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

        public void WriteGravityToConsole()
        {
            // 1. Lekerjuk az egitesteket
            List<SolarSystemBody> bodies = _solarSystemClient.GetAllBodies();

            // 2. Null check
            if(bodies != null) 
            {
                // 3. foreach ciklus használata (bodies: osszes egitest, body: aktualisan vizsgalt egitest)
                foreach (var body in bodies)
                {
                    if (body.IsPlanet)
                    {
                        Console.WriteLine($"{body.EnglishName}: {body.Gravity} N");
                    }
                }
            }
        }
    }
}
