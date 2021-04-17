using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SharpOfClans.Endpoints.Structs;
using SharpOfClans.Models.Clans;
using SharpOfClans.Models.Clans.Enums;

namespace SharpOfClans.Tests
{
    public abstract class TestBase
    {
        internal static IConfigurationRoot Configuration =
            new ConfigurationBuilder().AddJsonFile("testSettings.json").Build();

        public static readonly string Token = Configuration["Token"];

        protected static readonly ClashApi ClashApi = ClashApi.GetInstance(Token);

        public const string Clan1Tag = "#22Y0GPYQQ";
        public const string Clan2Tag = "#P800Q880";

        public const string MyProfileTag = "#L22YL908";
        public const string PlayerToken = "";
        
        public SearchFilter SearchFilter = new()
        {
            ClanName = "300",
            LabelIds = new List<string> { "56000000", "56000001", "56000004" },
            LocationId = 32000188,
            MaxMembers = 50,
            MinClanLevel = 2,
            MinClanPoints = 100,
            MinMembers = 2,
            WarFrequency = WarFrequency.Always
        };
    }
}
