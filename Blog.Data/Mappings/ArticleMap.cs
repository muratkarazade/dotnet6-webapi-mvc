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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);

            builder.HasData(new Article 
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Mvc Project",
                Content = "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",                
                CategoryId = Guid.Parse("2A956FE7-A026-4B02-8945-E7028BFF0CBE"),                
                ImageId = Guid.Parse("94A76B08-AE0D-4CEC-80CD-C65FEDBC2CDF"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted= false,
                ViewCount = 15
            },new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio",
                Content = "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",                
                CategoryId = Guid.Parse("94156901-724D-4025-9E53-AE772D0CE7F4"),               
                ImageId = Guid.Parse("0B72D57C-84FF-4B14-8EB2-5BBEF609523A"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                ViewCount = 32
            }
            
            );

        }
    }
}
