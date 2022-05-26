using System.Collections.Generic;

namespace Deepika.Models
{

    public static class Repository
    {
        private static List<Hospital> allHospitals = new List<Hospital>();
        public static IEnumerable<Hospital> AllHospitals
        {
            get { return allHospitals; }
        }
        public static void Create(Hospital hospital)
        {
            allHospitals.Add(hospital);
        }

        public static void Delete(Hospital hospital)
        {
            allHospitals.Remove(hospital);
        }
    }
}
