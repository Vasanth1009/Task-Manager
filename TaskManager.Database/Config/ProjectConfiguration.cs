﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Model;

namespace TaskManager.Database.Config
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Color).IsRequired();
            builder.Property(p => p.ViewType).IsRequired();
        }
    }
}
