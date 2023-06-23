using Bogus;
using Data.Entities;

namespace EmployeeDirectory.Data
{
    public static class SeedData
    { 
        static SeedData()
        {
            Randomizer.Seed = new Random(8675309);
        }
        public static Faker<Announcement> WebAppDev()
        {
            var userId = 1;
            var faker = new Faker("en");
            return new Faker<Announcement>()
                .RuleFor(u => u.Id, f => userId++)
                .RuleFor(u=>u.Title,f=>faker.Lorem.Word())
                .RuleFor(u=>u.Description,f=>faker.Lorem.Sentence())
                .RuleFor(u => u.DateAdded, f => f.Date.Between(new DateTime(2000,01,01),DateTime.Now));
        }
    }
}
