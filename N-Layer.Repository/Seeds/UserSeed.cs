using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Layer.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id = 1,
                Name = "Hasan",
                Email = "hasanilter003@gmail.com",
                Password = "123456Gs*",
                TeamId = 1,
            },
            new User
            {
                Id=2,
                Name = "Olgun",
                Email = "olgunbey003@gmail.com",
                Password = "123456Fb*",
                TeamId = 2,
            });
        }
    }
}
