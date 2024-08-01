using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Models;

namespace N_Layer.Repository.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id); //primary key
            builder.Property(x => x.Id).UseIdentityColumn(); //Id nin birer birer artması için
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(); //zorunlu olarak team name 50 den faza olamaz
        }
    }
}
