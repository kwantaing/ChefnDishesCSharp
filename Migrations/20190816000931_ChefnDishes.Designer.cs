﻿// <auto-generated />
using System;
using ChefnDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefnDishes.Migrations
{
    [DbContext(typeof(ChefnDishContext))]
    [Migration("20190816000931_ChefnDishes")]
    partial class ChefnDishes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ChefnDishes.Models.Chef", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("first_name")
                        .IsRequired();

                    b.Property<string>("last_name")
                        .IsRequired();

                    b.HasKey("user_id");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("ChefnDishes.Models.Dish", b =>
                {
                    b.Property<int>("dish_id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("calories");

                    b.Property<int?>("chefuser_id");

                    b.Property<string>("description");

                    b.Property<string>("name");

                    b.Property<int>("tastiness");

                    b.HasKey("dish_id");

                    b.HasIndex("chefuser_id");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("ChefnDishes.Models.Dish", b =>
                {
                    b.HasOne("ChefnDishes.Models.Chef", "chef")
                        .WithMany("Dishes")
                        .HasForeignKey("chefuser_id");
                });
#pragma warning restore 612, 618
        }
    }
}