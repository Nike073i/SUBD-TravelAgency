using Microsoft.EntityFrameworkCore;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.DatabaseContext
{
    public partial class TravelAgencyDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=TravelAgencyDB;Username=Skuld;Password=26041986");
            }
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.Contactnumber)
                    .HasName("client_contactnumber_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('client_seq'::regclass)");

                entity.Property(e => e.Contactnumber)
                    .IsRequired()
                    .HasColumnName("contactnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50);

                entity.Property(e => e.Secondname)
                    .IsRequired()
                    .HasColumnName("secondname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('countrie_seq'::regclass)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.ToTable("hotel");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('hotel_seq'::regclass)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.Contactnumber)
                    .IsRequired()
                    .HasColumnName("contactnumber")
                    .HasMaxLength(12);

                entity.Property(e => e.Countrieid).HasColumnName("countrieid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.Countrieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("hotel_countryfk");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sale");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('sale_seq'::regclass)");

                entity.Property(e => e.Clientid).HasColumnName("clientid");

                entity.Property(e => e.Dateofsale)
                    .HasColumnName("dateofsale")
                    .HasColumnType("date");

                entity.Property(e => e.Tourid).HasColumnName("tourid");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.Clientid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sale_clientfk");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.Tourid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sale_tourfk");
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.ToTable("tour");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('tour_seq'::regclass)");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Dateofbegininng)
                    .HasColumnName("dateofbegininng")
                    .HasColumnType("date");

                entity.Property(e => e.Hotelid).HasColumnName("hotelid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Numberofdays).HasColumnName("numberofdays");

                entity.Property(e => e.Numberofpeople).HasColumnName("numberofpeople");

                entity.Property(e => e.Publicationdate)
                    .HasColumnName("publicationdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Tour)
                    .HasForeignKey(d => d.Hotelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tour_hotelfk");
            });

            modelBuilder.HasSequence("client_seq");

            modelBuilder.HasSequence("countrie_seq").StartsAt(401);

            modelBuilder.HasSequence("hotel_seq").StartsAt(301);

            modelBuilder.HasSequence("sale_seq").StartsAt(101);

            modelBuilder.HasSequence("tour_seq").StartsAt(201);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
