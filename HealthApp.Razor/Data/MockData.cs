using Bogus;
using HealthApp.Domain;

namespace HealthApp.Razor.Data
{

    public static class MockData
    {

        public static List<Doctor> Doctors()
        {
            List<Doctor> doctors = new();

            var Faker = new Faker();

            for (int i = 0; i < 10; i++)
            {
                doctors.Add(new Doctor
                {
                    Id = i.ToString(),
                    FirstName = "Doc. " + Faker.Name.FirstName(),
                    LastName = Faker.Name.LastName(),
                    Email = Faker.Internet.Email(),
                });
            }

            return doctors;

        }

        public static List<Patient> Patients()
        {
            List<Patient> patients = new();

            var Faker = new Faker();

            for (int i = 0; i < 10; i++)
            {
                patients.Add(new Patient
                {
                    Id = i.ToString(),
                    FirstName = "Pat. " + Faker.Name.FirstName(),
                    LastName = Faker.Name.LastName(),
                    Email = Faker.Internet.Email(),
                });
            }

            return patients;
        }
    }
}