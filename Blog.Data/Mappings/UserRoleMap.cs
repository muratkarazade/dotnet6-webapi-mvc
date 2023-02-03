using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("26EBD897-2FCB-43F5-9DF4-1A8E00ABC34A"),
                RoleId = Guid.Parse("013C74D4-2133-40F5-AFF0-8A2B0D53B0D1")

            }, new AppUserRole
            {
                UserId = Guid.Parse("183153F8-19DA-4873-A14D-E3F113591644"),
                RoleId = Guid.Parse("635CD332-16D5-40AF-ADCC-EAF389B6CDFB")
            }

            );
        }
    }
}
