﻿using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>

    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Entregas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DueDate).IsRequired();
            builder.Property(x => x.Score).IsRequired();
            builder.Property(x => x.ModuleName);
            builder.Property(x => x.Description);
            builder.Property(x => x.Solution).IsRequired();
            builder.HasOne(x => x.Activity).WithMany(x => x.Deliveries).HasForeignKey(x => x.ActivityId);
            builder.HasOne(x => x.Student).WithMany(x => x.deliveries).HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
