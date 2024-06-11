using CRM.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MYCRM.DOMAIN.Entities;

namespace MYCRM.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User), "USR");

            builder
                .HasOne(e => e.CustomerFk) 
                .WithOne(e => e.UserFk) 
                .IsRequired();


        }
    }
}
