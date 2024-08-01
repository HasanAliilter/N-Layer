using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Models;

namespace N_Layer.Repository.Seeds
{
    public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData(new UserProfile
            {
                Id = 1,
                FirstName = "Hasan Ali",
                LastName = "İlter",
                UserId = 1,
            },
            new UserProfile
            {
                Id=2,
                FirstName = "Olgunbey",
                LastName = "Şahin",
                UserId = 2,
            });
        }
    }
}
