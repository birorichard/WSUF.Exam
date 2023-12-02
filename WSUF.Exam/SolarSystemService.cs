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
                        // 1. kiiras
                        if (body.EnglishName == "Moon")
                        {
                            // 2. kiiras
                            Console.WriteLine($"{body.EnglishName}: {body.Gravity} N");

                        }
                    }
                }
            }
        }

        public void WriteDetailedPlanetInfo()
        {
            // 1. Lekerjuk az egitesteket
            List<SolarSystemBody> bodies = _solarSystemClient.GetAllBodies();

            // 2. Null check
            if (bodies != null)
            {
                // 3. foreach ciklus használata (bodies: osszes egitest, body: aktualisan vizsgalt egitest)
                foreach (var body in bodies)
                {
                    if (body.IsPlanet)
                    {
                        // 1. kiiras body.Name body.EnglishName
                        // hasonlit erre:
                        Console.WriteLine($"{body.EnglishName}: {body.Gravity}");

                        // meg egy if, amiben vizsgaljuk, hogy a body.Gravity > 5 ?
                        if (?)
                        {
                            // 2. Kiiras - irjuk ki a body.Gravity-t
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        // public metodus, nincs visszateresi erteke, a neve pedig: WriteDetailedPlanetInfo
        // Az osszes egitest kozul, ami bolygo tipusu, azoknak ird ki a hagyomanyos, illetve angol nevet
        // egymas melle szokozzel elvalasztva (hagyomanyos nev: Name, az angol nev: EnglishName).

        // Egy uj sorban pedig legyen kiirva, hogy mekkora a gravitacioja, de csak akkor, ha a gravitacios
        // nagyobb mint 5. (gravitacio: Gravity)
    }
}
