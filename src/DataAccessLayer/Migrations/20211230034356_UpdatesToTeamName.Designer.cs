// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(FantasyFootballDbContext))]
    [Migration("20211230034356_UpdatesToTeamName")]
    partial class UpdatesToTeamName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FantasyFootballLibrary.ExtensionApplied", b =>
                {
                    b.Property<int>("ExtensionAppliedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Extend")
                        .HasColumnType("bit");

                    b.Property<bool>("Franchise")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("YearApplied")
                        .HasColumnType("int");

                    b.HasKey("ExtensionAppliedId");

                    b.HasIndex("TeamId");

                    b.HasIndex("PlayerId", "TeamId")
                        .IsUnique();

                    b.ToTable("ExtensionApplied");
                });

            modelBuilder.Entity("FantasyFootballLibrary.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractYears")
                        .HasColumnType("int");

                    b.Property<string>("NflTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerAge")
                        .HasColumnType("int");

                    b.Property<string>("PlayerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SleeperPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("FantasyFootballLibrary.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FourYearContracts")
                        .HasColumnType("int");

                    b.Property<int>("OneYearContracts")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreeYearContracts")
                        .HasColumnType("int");

                    b.Property<int>("TwoYearContracts")
                        .HasColumnType("int");

                    b.HasKey("TeamId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("FantasyFootballLibrary.ExtensionApplied", b =>
                {
                    b.HasOne("FantasyFootballLibrary.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FantasyFootballLibrary.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FantasyFootballLibrary.Player", b =>
                {
                    b.HasOne("FantasyFootballLibrary.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
