using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurant
{
    public partial class restaurantsContext : DbContext
    {
        public restaurantsContext()
        {
        }

        public restaurantsContext(DbContextOptions<restaurantsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<TableRes> TableRes { get; set; }
        public virtual DbSet<Waiter> Waiter { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=restaurants;Data Source=localhost");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>(entity =>
            {
                entity.Property(e => e.DishId).HasColumnName("dish_id");

                entity.Property(e => e.DishName)
                    .IsRequired()
                    .HasColumnName("dish_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DishDescription)
                    .HasColumnName("dish_description")
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnName("price")
                    .IsRequired();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddressResNavigation)
                    .WithMany(p => p.Dish)
                    .HasForeignKey(d => d.AddressRes)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Dish__address_re__73BA3083");
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.GuestId).HasColumnName("guest_id");
                
                entity.Property(e => e.NameBooker)
                    .IsRequired()
                    .HasColumnName("name_booker")
                    .HasMaxLength(50);

                entity.Property(e => e.TableNumber).HasColumnName("table_number");

                entity.Property(e => e.PartySize).HasColumnName("party_size");

                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AddressResNavigation)
                    .WithMany(p => p.Guest)
                    .HasForeignKey(d => d.AddressRes)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Guest__address_r__6A30C649");

                entity.HasOne(d => d.TableNumberNavigation)
                    .WithMany(p => p.Guest)
                    .HasForeignKey(d => d.TableNumber)
                    .HasConstraintName("FK__Guest__table_num__6B24EA82");
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100);

                entity.Property(e => e.NameRes)
                    .IsRequired()
                    .HasColumnName("name_res")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
                
                entity.HasKey(e => e.AddressRes)
                    .HasName("PK__Restaura__5D92AE2BA9E4B256");

            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.ReviewerName)
                    .HasColumnName("reviewer_name")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Anonymous')");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.ReviewText)
                    .HasColumnName("review_text")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100)
                    .IsRequired();
                
                entity.Property(e => e.DishId)
                    .HasColumnName("Dish_Id");

                entity.HasOne(d => d.AddressResNavigation)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.AddressRes)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Review__address___6FE99F9F");

                entity.HasOne(d => d.DishIdNavigation)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d=>d.DishId)
                    .HasConstraintName("FK_review_dish");
            });

            modelBuilder.Entity<TableRes>(entity =>
            {

                entity.Property(e => e.TableNumber)
                    .HasColumnName("table_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chairs).HasColumnName("chairs");

                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100);

                entity.ToTable("Table_res");

                entity.HasKey(e => e.TableNumber)
                    .HasName("PK__Table_re__21B232CF842EF4C1");


                entity.HasOne(d => d.AddressResNavigation)
                    .WithMany(p => p.TableRes)
                    .HasForeignKey(d => d.AddressRes)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Table_res__addre__628FA481");
            });

            modelBuilder.Entity<Waiter>(entity =>
            {
                entity.Property(e => e.WaiterId).HasColumnName("waiter_id");

                entity.Property(e => e.TableNumber).HasColumnName("table_number");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.AddressRes)
                    .HasColumnName("address_res")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddressResNavigation)
                    .WithMany(p => p.Waiter)
                    .HasForeignKey(d => d.AddressRes)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Waiter__address___656C112C");

                entity.HasOne(d => d.TableNumberNavigation)
                    .WithMany(p => p.Waiter)
                    .HasForeignKey(d => d.TableNumber)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Waiter__table_nu__66603565");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
