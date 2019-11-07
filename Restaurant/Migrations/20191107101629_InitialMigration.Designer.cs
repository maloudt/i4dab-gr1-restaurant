﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant;

namespace Restaurant.Migrations
{
    [DbContext(typeof(restaurantsContext))]
    [Migration("20191107101629_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dish_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Category")
                        .HasColumnName("category")
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("DishDescription")
                        .HasColumnName("dish_description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnName("dish_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("Price")
                        .HasColumnName("price")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("AddressRes");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("Restaurant.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("guest_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NameBooker")
                        .IsRequired()
                        .HasColumnName("name_booker")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("PartySize")
                        .HasColumnName("party_size")
                        .HasColumnType("int");

                    b.Property<int?>("TableNumber")
                        .HasColumnName("table_number")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnName("time")
                        .HasColumnType("datetime");

                    b.HasKey("GuestId");

                    b.HasIndex("AddressRes");

                    b.HasIndex("TableNumber");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("Restaurant.Restaurant", b =>
                {
                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NameRes")
                        .IsRequired()
                        .HasColumnName("name_res")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("AddressRes")
                        .HasName("PK__Restaura__5D92AE2BA9E4B256");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Restaurant.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("review_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ReviewText")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("review_text")
                        .HasColumnType("nvarchar(255)")
                        .HasDefaultValueSql("(' ')")
                        .HasMaxLength(255);

                    b.Property<string>("ReviewerName")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("reviewer_name")
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("('Annoymous')")
                        .HasMaxLength(50);

                    b.Property<int>("Stars")
                        .HasColumnName("stars")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnName("time")
                        .HasColumnType("datetime");

                    b.HasKey("ReviewId");

                    b.HasIndex("AddressRes");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Restaurant.TableRes", b =>
                {
                    b.Property<int>("TableNumber")
                        .HasColumnName("table_number")
                        .HasColumnType("int");

                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Chairs")
                        .HasColumnName("chairs")
                        .HasColumnType("int");

                    b.HasKey("TableNumber")
                        .HasName("PK__Table_re__21B232CF842EF4C1");

                    b.HasIndex("AddressRes");

                    b.ToTable("Table_res");
                });

            modelBuilder.Entity("Restaurant.Waiter", b =>
                {
                    b.Property<int>("WaiterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("waiter_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressRes")
                        .HasColumnName("address_res")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Salary")
                        .HasColumnName("salary")
                        .HasColumnType("int");

                    b.Property<int?>("TableNumber")
                        .HasColumnName("table_number")
                        .HasColumnType("int");

                    b.HasKey("WaiterId");

                    b.HasIndex("AddressRes");

                    b.HasIndex("TableNumber");

                    b.ToTable("Waiter");
                });

            modelBuilder.Entity("Restaurant.Dish", b =>
                {
                    b.HasOne("Restaurant.Restaurant", "AddressResNavigation")
                        .WithMany("Dish")
                        .HasForeignKey("AddressRes")
                        .HasConstraintName("FK__Dish__address_re__73BA3083")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Restaurant.Guest", b =>
                {
                    b.HasOne("Restaurant.Restaurant", "AddressResNavigation")
                        .WithMany("Guest")
                        .HasForeignKey("AddressRes")
                        .HasConstraintName("FK__Guest__address_r__6A30C649")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Restaurant.TableRes", "TableNumberNavigation")
                        .WithMany("Guest")
                        .HasForeignKey("TableNumber")
                        .HasConstraintName("FK__Guest__table_num__6B24EA82");
                });

            modelBuilder.Entity("Restaurant.Review", b =>
                {
                    b.HasOne("Restaurant.Restaurant", "AddressResNavigation")
                        .WithMany("Review")
                        .HasForeignKey("AddressRes")
                        .HasConstraintName("FK__Review__address___6FE99F9F")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Restaurant.TableRes", b =>
                {
                    b.HasOne("Restaurant.Restaurant", "AddressResNavigation")
                        .WithMany("TableRes")
                        .HasForeignKey("AddressRes")
                        .HasConstraintName("FK__Table_res__addre__628FA481")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Restaurant.Waiter", b =>
                {
                    b.HasOne("Restaurant.Restaurant", "AddressResNavigation")
                        .WithMany("Waiter")
                        .HasForeignKey("AddressRes")
                        .HasConstraintName("FK__Waiter__address___656C112C")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Restaurant.TableRes", "TableNumberNavigation")
                        .WithMany("Waiter")
                        .HasForeignKey("TableNumber")
                        .HasConstraintName("FK__Waiter__table_nu__66603565")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
