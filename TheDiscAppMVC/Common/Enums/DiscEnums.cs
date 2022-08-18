﻿using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Common.Enums
{
    public class DiscEnums
    {
        public enum BrandEnum
        {
            [Display(Name = "3CDiscs")] ThreeCDiscs,
            [Display(Name = "Above Ground Level")] AboveGroundLevel,
            Aerobie,
            [Display(Name = "Albatross Disc Golf")] AlbatrossDG,
            [Display(Name = "Alfa Discs")] AlfaDiscs,
            [Display(Name = "All 4 Frisbee")] AllForFrisbee,
            [Display(Name = "AquaFlight Discs")] AquaFlight,
            [Display(Name = "Arsenal Discs")] Arsenal,
            [Display(Name = "Axiom Discs")] Axiom,
            [Display(Name = "Best Disc Golf Discs")] BestDiscGolfDiscs,
            Birdie,
            [Display(Name = "Black Zombie Disc Golf")] BlackZombieDG,
            [Display(Name = "Cheap Discs")] CheapDiscs,
            [Display(Name = "Cheengz/Hyperflite")] CheengzHyperflite,
            [Display(Name = "Clash Discs")] ClashDiscs,
            [Display(Name = "Crosslap Disc Golf Parks")] CrosslapDiscGolfParks,
            [Display(Name = "Daredevil Discs")] DaredevilDiscs,
            [Display(Name = "Disc Golf Association")] DiscGolfAssociation,
            [Display(Name = "Disc Golf UK Ltd.")] DiscGolfUKLtd,
            [Display(Name = "Disc King")] DiscKing,
            Discmania,
            Discraft,
            [Display(Name = "Disctroyer OÜ")] DisctroyerOÜ,
            [Display(Name = "Divergent Discs")] DivergentDiscs,
            [Display(Name = "Doomsday Discs")] DoomsdayDiscs,
            [Display(Name = "Dynamic Discs")] DynamicDiscs,
            [Display(Name = "Element Discs")] ElementDiscs,
            [Display(Name = "Elevation Disc Golf")] ElevationDiscGolf,
            [Display(Name = "EMSCO Group")] EMSCOGroup,
            [Display(Name = "Essential Discs")] EssentialDiscs,
            Eurodisc,
            [Display(Name = "EV-7")] EVSeven,
            [Display(Name = "Exel Discs")] ExelDiscs,
            [Display(Name = "Finish Line Discs")] FinishLineDiscs,
            FlyTec,
            [Display(Name = "Franklin Sports")] FranklinSports,
            [Display(Name = "Full Turn Discs")] FullTurnDiscs,
            [Display(Name = "Galaxy Disc Golf")] GalaxyDiscGolf,
            [Display(Name = "Gateway Disc Sports")] GatewayDiscSports,
            [Display(Name = "Goliath Discs")] GoliathDiscs,
            [Display(Name = "GT Discs")] GTDiscs,
            Guru,
            [Display(Name = "Hero Disc")] HeroDisc,
            Hobbysport,
            [Display(Name = "Hole19 sarl")] Hole19sarl,
            [Display(Name = "Hooligan Discs")] HooliganDiscs,
            [Display(Name = "Infinite Discs")] InfiniteDiscs,
            [Display(Name = "Innova Champion Discs")] InnovaChampionDiscs,
            [Display(Name = "Innova Factory Store")] InnovaFactoryStore,
            Kastaplast,
            [Display(Name = "Kestrel Outdoors")] KestrelOutdoors,
            [Display(Name = "Las Aves Disc Golf")] LasAvesDiscGolf,
            [Display(Name = "Latitude 64")] Latitude64,
            [Display(Name = "Launch Disc Golf")] LaunchDiscGolf,
            [Display(Name = "LB Sport Loisir")] LBSportLoisir,
            [Display(Name = "Legacy Discs")] LegacyDiscs,
            [Display(Name = "Lone Star Disc")] LoneStarDisc,
            [Display(Name = "Lucky Discs")] LuckyDiscs,
            [Display(Name = "Løft Discs")] LøftDiscs,
            [Display(Name = "Millennium Golf Discs")] MillenniumGolfDiscs,
            [Display(Name = "Mint Discs")] MintDiscs,
            [Display(Name = "Momentum Disc Golf AB")] MomentumDiscGolfAB,
            [Display(Name = "MVP Disc Sports")] MVPDiscSports,
            [Display(Name = "Neptune Discs")] NeptuneDiscs,
            [Display(Name = "Newb SimHouse Custom Discs")] NewbSimHouseCustomDiscs,
            Nordisc,
            Northstardisc,
            [Display(Name = "Obsidian Discs Oy")] ObsidianDiscsOy,
            ODDGRIP,
            [Display(Name = "Pacific Cycle")] PacificCycle,
            [Display(Name = "Paradigm Disc Golf")] ParadigmDiscGolf,
            [Display(Name = "Parked LLC")] ParkedLLC,
            [Display(Name = "Pie Pan Discs")] PiePanDiscs,
            [Display(Name = "Plastic Addicts")] PlasticAddicts,
            [Display(Name = "Premier Discs")] PremierDiscs,
            [Display(Name = "Prodigy Disc")] ProdigyDisc,
            Prodiscus,
            [Display(Name = "Reptilian Disc Golf")] ReptilianDiscGolf,
            [Display(Name = "RPM Discs/Disc Golf Aotearoa")] RPMDiscsDiscGolfAotearoa,
            Sector,
            [Display(Name = "Skyquest Discs")] SkyquestDiscs,
            Sportme,
            [Display(Name = "Storm Disc Golf")] StormDiscGolf,
            [Display(Name = "Streamline Discs")] StreamlineDiscs,
            [Display(Name = "Synergy Discs")] SynergyDiscs,
            [Display(Name = "Taito Frisbeegolf")] TaitoFrisbeegolf,
            [Display(Name = "Terminal Velocity Discs")] TerminalVelocityDiscs,
            [Display(Name = "Thought Space Athletics")] ThoughtSpaceAthletics,
            [Display(Name = "Tobu Discs")] TobuDiscs,
            [Display(Name = "Tokyo Discs")] TokyoDiscs,
            [Display(Name = "Tornado Throw")] TornadoThrow,
            TOSY,
            [Display(Name = "Universal Play Disc Golf")] UniversalPlayDiscGolf,
            [Display(Name = "Vibram Disc Golf")] VibramDiscGolf,
            [Display(Name = "Viking Discs (IP-Agency Finland Oy)")] VikingDiscsIPAgencyFinlandOy,
            [Display(Name = "Westside Golf Discs")] WestsideGolfDiscs,
            [Display(Name = "Wham-O, Inc.")] WhamOInc,
            [Display(Name = "Wild Discs")] WildDiscs,
            [Display(Name = "Windward Discs")] WindwardDiscs,
            [Display(Name = "Wing It Disc Golf")] WingItDiscGolf,
            [Display(Name = "XCOM Discs")] XCOMDiscs,
            [Display(Name = "Yikun Discs")] YikunDiscs,
        }

        public enum StabilityEnum
        {
            [Display(Name = "Very Overstable")] VOverstable,
            Overtstable,
            Stable,
            Understable,
            [Display(Name = "Very Understable")] VUnderstable
        }

        public enum DiscTypeEnum
        {
            [Display(Name = "Distance Driver")] DDriver,
            [Display(Name = "Fairway Driver")] FDriver,
            Midrange,
            Putter
        }

        public enum SpeedEnum
        {
            [Display(Name = "1")] OneSpeed,
            [Display(Name = "2")] TwoSpeed,
            [Display(Name = "3")] ThreeSpeed,
            [Display(Name = "4")] FourSpeed,
            [Display(Name = "5")] FiveSpeed,
            [Display(Name = "6")] SixSpeed,
            [Display(Name = "7")] SevenSpeed,
            [Display(Name = "8")] EightSpeed,
            [Display(Name = "9")] NineSpeed,
            [Display(Name = "10")] TenSpeed,
            [Display(Name = "11")] ElevenSpeed,
            [Display(Name = "12")] TwelveSpeed,
            [Display(Name = "13")] ThirteenSpeed,
            [Display(Name = "14")] FourteenSpeed,
            [Display(Name = "15")] FifteenSpeed
        }

        public enum GlideEnum
        {
            [Display(Name = "1")] OneGlide,
            [Display(Name = "2")] TwoGlide,
            [Display(Name = "3")] ThreeGlide,
            [Display(Name = "4")] FourGlide,
            [Display(Name = "5")] FiveGlide,
            [Display(Name = "6")] SixGlide,
            [Display(Name = "7")] SevenGlide,
        }

        public enum TurnEnum
        {
            [Display(Name = "+1")] OneGlide,
            [Display(Name = "0")] ZeroGlide,
            [Display(Name = "-1")] NegOneGlide,
            [Display(Name = "-2")] NegTwoGlide,
            [Display(Name = "-3")] NegThreeGlide,
            [Display(Name = "-4")] NegFourGlide,
            [Display(Name = "-5")] NegFiveGlide,
        }

        public enum FadeEnum
        {
            [Display(Name = "0")] ZeroFade,
            [Display(Name = "1")] OneFade,
            [Display(Name = "2")] TwoFade,
            [Display(Name = "3")] ThreeFade,
            [Display(Name = "4")] FourFade,
            [Display(Name = "5")] FiveFade,
        }
    }
}
