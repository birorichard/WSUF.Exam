namespace WSUF.Exam.Model
{
    public class SolarSystemApiGetBodiesResponse
    {
        public List<SolarSystemBody>? Bodies { get; set; }
    }
    public class SolarSystemBody
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? EnglishName { get; set; }
        public bool IsPlanet { get; set; }
        public List<SolarSystemMoon>? Moons { get; set; }
        public long SemimajorAxis { get; set; }
        public long Perihelion { get; set; }
        public long Aphelion { get; set; }
        public decimal? Eccentricity { get; set; }
        public decimal? Inclination { get; set; }
        public SolarSystemMass? Mass { get; set; }
        public SolarSystemVol? Vol { get; set; }
        public decimal? Density { get; set; }
        public decimal? Gravity { get; set; }
        public decimal? Escape { get; set; }
        public decimal? MeanRadius { get; set; }
        public decimal? EquaRadius { get; set; }
        public decimal? PolarRadius { get; set; }
        public decimal? Flattening { get; set; }
        public string? Dimension { get; set; }
        public decimal? SideralOrbit { get; set; }
        public decimal? SideralRotation { get; set; }
        public SolarSystemAroundPlanet? AroundPlanet { get; set; }
        public string? DiscoveredBy { get; set; }
        public string? DiscoveryDate { get; set; }
        public string? AlternativeName { get; set; }
        public decimal? AxialTilt { get; set; }
        public int AvgTemp { get; set; }
        public decimal? MainAnomaly { get; set; }
        public decimal? ArgPeriapsis { get; set; }
        public decimal? LongAscNode { get; set; }
        public string? BodyType { get; set; }
        public string? Rel { get; set; }
    }

    public class SolarSystemMoon
    {
        public string? Moon { get; set; }
        public string? Rel { get; set; }
    }

    public class SolarSystemMass
    {
        public decimal? MassValue { get; set; }
        public int MassExponent { get; set; }
    }

    public class SolarSystemVol
    {
        public decimal? VolValue { get; set; }
        public int VolExponent { get; set; }
    }

    public class SolarSystemAroundPlanet
    {
        public string? Planet { get; set; }
        public string? Rel { get; set; }
    }
}
