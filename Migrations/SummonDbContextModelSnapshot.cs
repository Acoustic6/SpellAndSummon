﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpellAndSummon.Persistence;

namespace SpellAndSummon.Migrations
{
    [DbContext(typeof(SummonDbContext))]
    partial class SummonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpellAndSummon.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardText")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("CardType");

                    b.Property<int>("ManaCost");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("SpellAndSummon.Models.CardDeck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("CardId");

                    b.Property<int>("DeckId");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DeckId");

                    b.ToTable("CardDecks");
                });

            modelBuilder.Entity("SpellAndSummon.Models.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("SpellAndSummon.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Surname")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SpellAndSummon.Models.SpecialAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SpecialAbilities");
                });

            modelBuilder.Entity("SpellAndSummon.Models.SpecialAbilityCard", b =>
                {
                    b.Property<int>("CardId");

                    b.Property<int>("SpecialAbilityId");

                    b.HasKey("CardId", "SpecialAbilityId");

                    b.HasIndex("SpecialAbilityId");

                    b.ToTable("SpecialAbilityCards");
                });

            modelBuilder.Entity("SpellAndSummon.Models.CardDeck", b =>
                {
                    b.HasOne("SpellAndSummon.Models.Card", "Card")
                        .WithMany("CardDecks")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpellAndSummon.Models.Deck", "Deck")
                        .WithMany("CardDecks")
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpellAndSummon.Models.Deck", b =>
                {
                    b.HasOne("SpellAndSummon.Models.Player", "Player")
                        .WithMany("Decks")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpellAndSummon.Models.SpecialAbilityCard", b =>
                {
                    b.HasOne("SpellAndSummon.Models.Card", "Card")
                        .WithMany("SpecialAbilityCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpellAndSummon.Models.SpecialAbility", "SpecialAbility")
                        .WithMany("SpecialAbilityCards")
                        .HasForeignKey("SpecialAbilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
