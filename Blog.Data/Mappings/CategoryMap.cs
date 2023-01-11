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
            builder.HasData(
                 new Category
                 {
                     Id = Guid.Parse("A26FFA43-78A3-414B-89E7-83AF238D4BD4"),
                     Name = "Asp.Net Core",
                     CreatedBy = "Admin Test",
                     CreatedDate = DateTime.Now,
                     IsDeleted = false
                 },


                new Category
                {
                    Id = Guid.Parse("98E0002D-19E4-446C-AA10-9C408632375D"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                });
        }
    }
}
