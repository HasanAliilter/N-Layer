using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Models;

namespace N_Layer.Repository.Seeds
{
    public class TeamSeed : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team
                {
                    Id = 1,
                    Name = "Development"
                },
                new Team 
                {
                    Id = 2,
                    Name = "Marketing"
                },
                new Team
                {
                    Id = 3,
                    Name = "Sales"
                });
        }
    }
}
