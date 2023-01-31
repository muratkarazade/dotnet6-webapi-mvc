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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("94A76B08-AE0D-4CEC-80CD-C65FEDBC2CDF"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                FileName = "images/testImage",
                FileType = "jpg",
                IsDeleted = false
            },new Image
            {
                Id = Guid.Parse("0B72D57C-84FF-4B14-8EB2-5BBEF609523A"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                FileName = "images/testImage2",
                FileType = "png",
                IsDeleted = false
            }
            
            );
        }
    }
}
