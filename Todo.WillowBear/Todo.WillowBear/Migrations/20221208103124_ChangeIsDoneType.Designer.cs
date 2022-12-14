// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.WillowBear.Data;

#nullable disable

namespace Todo.WillowBear.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20221208103124_ChangeIsDoneType")]
    partial class ChangeIsDoneType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Todo.WillowBear.Models.TodoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime('now')");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TodoItems", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
