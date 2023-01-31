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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("94156901-724D-4025-9E53-AE772D0CE7F4"),
                Name = ".Net Teknolojileri",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }, new Category
            {

                Id = Guid.Parse("2A956FE7-A026-4B02-8945-E7028BFF0CBE"),
                Name = ".Net Teknolojileri",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }

            );
        }
    }
}
