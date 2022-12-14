// <auto-generated />
using System;
using LogicaAccesoDatos.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogicaAccesoDatos.Migrations
{
    [DbContext(typeof(ObligatorioContext))]
    [Migration("20221008231636_fkGS-NT")]
    partial class fkGSNT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LogicaNegocio.Entidades.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.GroupStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("GroupsStage");
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AwayId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("HomeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayId");

                    b.HasIndex("HomeId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.MatchResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("MatchResult");
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.NationalTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupStageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GroupStageId");

                    b.ToTable("NationalTeams");
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.Country", b =>
                {
                    b.OwnsOne("LogicaNegocio.VO.ISOAlfa3Value", "IsoAlfa3", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("IsoAlfa3")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CountryId");

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.NameValue", "Name", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CountryId");

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveFloatValue", "GDP", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<decimal>("Value")
                                .HasColumnName("GDP")
                                .HasColumnType("decimal(18,4)");

                            b1.HasKey("CountryId");

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "Population", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Population")
                                .HasColumnType("int");

                            b1.HasKey("CountryId");

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.RegionValue", "Region", b1 =>
                        {
                            b1.Property<int>("CountryId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("Region")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CountryId");

                            b1.ToTable("Countries");

                            b1.WithOwner()
                                .HasForeignKey("CountryId");
                        });
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.GroupStage", b =>
                {
                    b.OwnsOne("LogicaNegocio.VO.CodeValue", "Group", b1 =>
                        {
                            b1.Property<int>("GroupStageId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("Group")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("GroupStageId");

                            b1.ToTable("GroupsStage");

                            b1.WithOwner()
                                .HasForeignKey("GroupStageId");
                        });
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.Match", b =>
                {
                    b.HasOne("LogicaNegocio.Entidades.NationalTeam", "Away")
                        .WithMany()
                        .HasForeignKey("AwayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LogicaNegocio.Entidades.NationalTeam", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("LogicaNegocio.VO.MatchDate", "MatchDate", b1 =>
                        {
                            b1.Property<int>("MatchId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<DateTime>("Value")
                                .HasColumnName("Match_Date")
                                .HasColumnType("datetime2");

                            b1.HasKey("MatchId");

                            b1.ToTable("Match");

                            b1.WithOwner()
                                .HasForeignKey("MatchId");
                        });
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.MatchResult", b =>
                {
                    b.HasOne("LogicaNegocio.Entidades.GroupStage", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("LogicaNegocio.Entidades.Match", "Match")
                        .WithOne("MatchResult")
                        .HasForeignKey("LogicaNegocio.Entidades.MatchResult", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "DirectRedCardsA", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Red_Direct_Card_Away")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "DirectRedCardsH", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Red_Direct_Card_Home")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "GoalsA", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Goals_Away")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "GoalsH", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Goals_Home")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "RedCardsA", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Red_Cards_Away")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "RedCardsH", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Red_Cards_Home")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "YellowCardsA", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Yellow_Cards_Away")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "YellowCardsH", b1 =>
                        {
                            b1.Property<int>("MatchResultId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Yellow_Cards_Home")
                                .HasColumnType("int");

                            b1.HasKey("MatchResultId");

                            b1.ToTable("MatchResult");

                            b1.WithOwner()
                                .HasForeignKey("MatchResultId");
                        });
                });

            modelBuilder.Entity("LogicaNegocio.Entidades.NationalTeam", b =>
                {
                    b.HasOne("LogicaNegocio.Entidades.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("LogicaNegocio.Entidades.GroupStage", "GroupStage")
                        .WithMany("NationalTeams")
                        .HasForeignKey("GroupStageId");

                    b.OwnsOne("LogicaNegocio.VO.EmailValue", "Email", b1 =>
                        {
                            b1.Property<int>("NationalTeamId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NationalTeamId");

                            b1.ToTable("NationalTeams");

                            b1.WithOwner()
                                .HasForeignKey("NationalTeamId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.NameValue", "Name", b1 =>
                        {
                            b1.Property<int>("NationalTeamId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NationalTeamId");

                            b1.ToTable("NationalTeams");

                            b1.WithOwner()
                                .HasForeignKey("NationalTeamId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PhoneNumber", "Phone", b1 =>
                        {
                            b1.Property<int>("NationalTeamId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .HasColumnName("Phone")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NationalTeamId");

                            b1.ToTable("NationalTeams");

                            b1.WithOwner()
                                .HasForeignKey("NationalTeamId");
                        });

                    b.OwnsOne("LogicaNegocio.VO.PositiveIntegerValue", "Bettors", b1 =>
                        {
                            b1.Property<int>("NationalTeamId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnName("Bettors")
                                .HasColumnType("int");

                            b1.HasKey("NationalTeamId");

                            b1.ToTable("NationalTeams");

                            b1.WithOwner()
                                .HasForeignKey("NationalTeamId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
