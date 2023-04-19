﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksLookupApi.Models;

#nullable disable

namespace ParksLookupApi.Migrations
{
    [DbContext(typeof(ParksLookupApiContext))]
    [Migration("20230120190712_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksLookupApi.Models.Park", b =>
                {
                    b.Property<int>("park_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("state_id")
                        .HasColumnType("int");

                    b.HasKey("park_id");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            park_id = 1,
                            name = "Acadia",
                            state_id = 19
                        },
                        new
                        {
                            park_id = 2,
                            name = "American Samoa",
                            state_id = 15
                        },
                        new
                        {
                            park_id = 3,
                            name = "Arches",
                            state_id = 3
                        },
                        new
                        {
                            park_id = 4,
                            name = "Badlands",
                            state_id = 10
                        },
                        new
                        {
                            park_id = 5,
                            name = "Big Bend",
                            state_id = 11
                        },
                        new
                        {
                            park_id = 6,
                            name = "Biscayne",
                            state_id = 6
                        },
                        new
                        {
                            park_id = 7,
                            name = "Black Canyon of the Gunnison",
                            state_id = 4
                        },
                        new
                        {
                            park_id = 8,
                            name = "Bryce Canyon",
                            state_id = 3
                        },
                        new
                        {
                            park_id = 9,
                            name = "Canyonlands",
                            state_id = 3
                        },
                        new
                        {
                            park_id = 10,
                            name = "Capitol Reef",
                            state_id = 3
                        },
                        new
                        {
                            park_id = 11,
                            name = "Carlsbad Caverns",
                            state_id = 9
                        },
                        new
                        {
                            park_id = 12,
                            name = "Channel Islands",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 13,
                            name = "Congaree",
                            state_id = 26
                        },
                        new
                        {
                            park_id = 14,
                            name = "Crater Lake",
                            state_id = 25
                        },
                        new
                        {
                            park_id = 15,
                            name = "Cuyahoga Valley",
                            state_id = 24
                        },
                        new
                        {
                            park_id = 16,
                            name = "Death Valley",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 17,
                            name = "Denali",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 18,
                            name = "Dry Tortugas",
                            state_id = 6
                        },
                        new
                        {
                            park_id = 19,
                            name = "Everglades",
                            state_id = 6
                        },
                        new
                        {
                            park_id = 20,
                            name = "Gates of the Arctic",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 21,
                            name = "Gateway Arch",
                            state_id = 22
                        },
                        new
                        {
                            park_id = 22,
                            name = "Glacier",
                            state_id = 12
                        },
                        new
                        {
                            park_id = 23,
                            name = "Glacier Bay",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 24,
                            name = "Grand Canyon",
                            state_id = 5
                        },
                        new
                        {
                            park_id = 25,
                            name = "Grand Teton",
                            state_id = 14
                        },
                        new
                        {
                            park_id = 26,
                            name = "Great Basin",
                            state_id = 13
                        },
                        new
                        {
                            park_id = 27,
                            name = "Great Sand Dunes",
                            state_id = 4
                        },
                        new
                        {
                            park_id = 28,
                            name = "Great Smoky Mountains",
                            state_id = 31
                        },
                        new
                        {
                            park_id = 29,
                            name = "Guadalupe Mountains",
                            state_id = 11
                        },
                        new
                        {
                            park_id = 30,
                            name = "Haleakalā",
                            state_id = 8
                        },
                        new
                        {
                            park_id = 31,
                            name = "Hawai'i Volcanoes",
                            state_id = 8
                        },
                        new
                        {
                            park_id = 32,
                            name = "Hot Springs",
                            state_id = 16
                        },
                        new
                        {
                            park_id = 33,
                            name = "Indiana Dunes",
                            state_id = 17
                        },
                        new
                        {
                            park_id = 34,
                            name = "Isle Royale",
                            state_id = 20
                        },
                        new
                        {
                            park_id = 35,
                            name = "Joshua Tree",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 36,
                            name = "Katmai",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 37,
                            name = "Kenai Fjords",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 38,
                            name = "Kings Canyon",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 39,
                            name = "Kobuk Valley",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 40,
                            name = "Lake Clark",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 41,
                            name = "Lassen Volcanic",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 42,
                            name = "Mammoth Cave",
                            state_id = 18
                        },
                        new
                        {
                            park_id = 43,
                            name = "Mesa Verde",
                            state_id = 4
                        },
                        new
                        {
                            park_id = 44,
                            name = "Mount Rainier",
                            state_id = 7
                        },
                        new
                        {
                            park_id = 45,
                            name = "New River Gorge",
                            state_id = 28
                        },
                        new
                        {
                            park_id = 46,
                            name = "North Cascades",
                            state_id = 7
                        },
                        new
                        {
                            park_id = 47,
                            name = "Olympic",
                            state_id = 7
                        },
                        new
                        {
                            park_id = 48,
                            name = "Petrified Forest",
                            state_id = 5
                        },
                        new
                        {
                            park_id = 49,
                            name = "Pinnacles",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 50,
                            name = "Redwood",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 51,
                            name = "Rocky Mountain",
                            state_id = 4
                        },
                        new
                        {
                            park_id = 52,
                            name = "Saguaro",
                            state_id = 5
                        },
                        new
                        {
                            park_id = 53,
                            name = "Sequoia",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 54,
                            name = "Shenandoah",
                            state_id = 28
                        },
                        new
                        {
                            park_id = 55,
                            name = "Theodore Roosevelt",
                            state_id = 23
                        },
                        new
                        {
                            park_id = 56,
                            name = "Virgin Islands",
                            state_id = 27
                        },
                        new
                        {
                            park_id = 57,
                            name = "Voyageurs",
                            state_id = 21
                        },
                        new
                        {
                            park_id = 58,
                            name = "White Sands",
                            state_id = 9
                        },
                        new
                        {
                            park_id = 59,
                            name = "Wind Cave",
                            state_id = 10
                        },
                        new
                        {
                            park_id = 60,
                            name = "Wrangell-St.Elias",
                            state_id = 2
                        },
                        new
                        {
                            park_id = 61,
                            name = "Yellowstone",
                            state_id = 12
                        },
                        new
                        {
                            park_id = 62,
                            name = "Yosemite",
                            state_id = 1
                        },
                        new
                        {
                            park_id = 63,
                            name = "Zion",
                            state_id = 3
                        });
                });

            modelBuilder.Entity("ParksLookupApi.Models.State", b =>
                {
                    b.Property<int>("state_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("park_count")
                        .HasColumnType("int");

                    b.HasKey("state_id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            state_id = 1,
                            name = "California",
                            park_count = 9
                        },
                        new
                        {
                            state_id = 2,
                            name = "Alaska",
                            park_count = 8
                        },
                        new
                        {
                            state_id = 3,
                            name = "Utah",
                            park_count = 5
                        },
                        new
                        {
                            state_id = 4,
                            name = "Colorado",
                            park_count = 4
                        },
                        new
                        {
                            state_id = 5,
                            name = "Arizona",
                            park_count = 3
                        },
                        new
                        {
                            state_id = 6,
                            name = "Florida",
                            park_count = 3
                        },
                        new
                        {
                            state_id = 7,
                            name = "Washington",
                            park_count = 3
                        },
                        new
                        {
                            state_id = 8,
                            name = "Hawaii",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 9,
                            name = "New Mexico",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 10,
                            name = "South Dakota",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 11,
                            name = "Texas",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 12,
                            name = "Montana",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 13,
                            name = "Nevada",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 14,
                            name = "Wyoming",
                            park_count = 2
                        },
                        new
                        {
                            state_id = 15,
                            name = "American Samoa",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 16,
                            name = "Arkansas",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 17,
                            name = "Indiana",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 18,
                            name = "Kentucky",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 19,
                            name = "Maine",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 20,
                            name = "Michigan",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 21,
                            name = "Minnesota",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 22,
                            name = "Missouri",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 23,
                            name = "North Dakota",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 24,
                            name = "Ohio",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 25,
                            name = "Oregon",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 26,
                            name = "South Carolina",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 27,
                            name = "U.S. Virgin Islands",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 28,
                            name = "Virginia",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 29,
                            name = "West Virginia",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 30,
                            name = "Idaho",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 31,
                            name = "North Carolina",
                            park_count = 1
                        },
                        new
                        {
                            state_id = 32,
                            name = "Tennessee",
                            park_count = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}