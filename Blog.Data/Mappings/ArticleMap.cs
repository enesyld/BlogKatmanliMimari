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
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ViewCount = 15,
                CategoryId= Guid.Parse("A26FFA43-78A3-414B-89E7-83AF238D4BD4"),
                ImageId = Guid.Parse("34592E9F-8D43-4218-97B9-9B9E5A90A1A6"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi",
                Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec erat varius, accumsan eros vitae, sodales risus. Vivamus volutpat tellus id sapien lacinia, vel fringilla leo condimentum. Curabitur accumsan, nunc sed pellentesque faucibus, dolor elit eleifend ligula, nec blandit dolor eros ut libero. Etiam a nulla quis urna accumsan placerat id in nisi. Donec et nibh leo. Donec tempus neque urna. Vivamus pulvinar erat egestas rutrum malesuada. Donec urna quam, tristique eu faucibus molestie, semper ut dui. Mauris vitae congue tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                ViewCount = 15,
                CategoryId=Guid.Parse("98E0002D-19E4-446C-AA10-9C408632375D"),
                ImageId=Guid.Parse("FFB69ADC-97ED-448E-80EE-B4E8659F9A87"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }
            );
        }
    }
}
