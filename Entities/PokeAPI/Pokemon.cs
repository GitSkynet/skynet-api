using Entities.Base;
using Newtonsoft.Json;

namespace Entities.PokeAPI
{
    public class Pokemon : EntityBase
    {
        [JsonProperty("abilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("base_experience", NullValueHandling = NullValueHandling.Ignore)]
        public int? BaseExperience { get; set; }

        [JsonProperty("cries", NullValueHandling = NullValueHandling.Ignore)]
        public Cries Cries { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public List<Form> Forms { get; set; }

        [JsonProperty("game_indices", NullValueHandling = NullValueHandling.Ignore)]
        public List<GameIndex> GameIndices { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        [JsonProperty("held_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<HeldItem> HeldItems { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdOnAPI { get; set; }

        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        [JsonProperty("location_area_encounters", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("moves", NullValueHandling = NullValueHandling.Ignore)]
        public List<Move> Moves { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        [JsonProperty("past_abilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> PastAbilities { get; set; }

        [JsonProperty("past_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> PastTypes { get; set; }

        [JsonProperty("species", NullValueHandling = NullValueHandling.Ignore)]
        public Species Species { get; set; }

        [JsonProperty("sprites", NullValueHandling = NullValueHandling.Ignore)]
        public Sprites Sprites { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stat> Stats { get; set; }

        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<Type> Types { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Ability
    {
        [JsonProperty("ability", NullValueHandling = NullValueHandling.Ignore)]
        public TheAbility Ability { get; set; }

        [JsonProperty("is_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHidden { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public int? Slot { get; set; }
    }

    public class TheAbility
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class Animated
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class BlackWhite
    {
        [JsonProperty("animated", NullValueHandling = NullValueHandling.Ignore)]
        public Animated Animated { get; set; }

        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Cries
    {
        [JsonProperty("latest", NullValueHandling = NullValueHandling.Ignore)]
        public string Latest { get; set; }

        [JsonProperty("legacy", NullValueHandling = NullValueHandling.Ignore)]
        public string Legacy { get; set; }
    }

    public class Crystal
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyTransparent { get; set; }

        [JsonProperty("back_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyTransparent { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }

    public class DiamondPearl
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class DreamWorld
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public object FrontFemale { get; set; }
    }

    public class Emerald
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }
    }

    public class FireredLeafgreen
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }
    }

    public class Form
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class GameIndex
    {
        [JsonProperty("game_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? TheGameIndex { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }
    }

    public class GenerationI
    {
        [JsonProperty("red-blue", NullValueHandling = NullValueHandling.Ignore)]
        public RedBlue RedBlue { get; set; }

        [JsonProperty("yellow", NullValueHandling = NullValueHandling.Ignore)]
        public Yellow Yellow { get; set; }
    }

    public class GenerationIi
    {
        [JsonProperty("crystal", NullValueHandling = NullValueHandling.Ignore)]
        public Crystal Crystal { get; set; }

        [JsonProperty("gold", NullValueHandling = NullValueHandling.Ignore)]
        public Gold Gold { get; set; }

        [JsonProperty("silver", NullValueHandling = NullValueHandling.Ignore)]
        public Silver Silver { get; set; }
    }

    public class GenerationIii
    {
        [JsonProperty("emerald", NullValueHandling = NullValueHandling.Ignore)]
        public Emerald Emerald { get; set; }

        [JsonProperty("firered-leafgreen", NullValueHandling = NullValueHandling.Ignore)]
        public FireredLeafgreen FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire", NullValueHandling = NullValueHandling.Ignore)]
        public RubySapphire RubySapphire { get; set; }
    }

    public class GenerationIv
    {
        [JsonProperty("diamond-pearl", NullValueHandling = NullValueHandling.Ignore)]
        public DiamondPearl DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver", NullValueHandling = NullValueHandling.Ignore)]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }

        [JsonProperty("platinum", NullValueHandling = NullValueHandling.Ignore)]
        public Platinum Platinum { get; set; }
    }

    public class GenerationV
    {
        [JsonProperty("black-white", NullValueHandling = NullValueHandling.Ignore)]
        public BlackWhite BlackWhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonProperty("omegaruby-alphasapphire", NullValueHandling = NullValueHandling.Ignore)]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }

        [JsonProperty("x-y", NullValueHandling = NullValueHandling.Ignore)]
        public XY XY { get; set; }
    }

    public class GenerationVii
    {
        [JsonProperty("icons", NullValueHandling = NullValueHandling.Ignore)]
        public Icons Icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon", NullValueHandling = NullValueHandling.Ignore)]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }

    public class GenerationViii
    {
        [JsonProperty("icons", NullValueHandling = NullValueHandling.Ignore)]
        public Icons Icons { get; set; }
    }

    public class Gold
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class HeldItem
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public Item Item { get; set; }

        [JsonProperty("version_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionDetail> VersionDetails { get; set; }
    }

    public class Home
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Icons
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public object FrontFemale { get; set; }
    }

    public class Item
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class Move
    {
        [JsonProperty("move", NullValueHandling = NullValueHandling.Ignore)]
        public Move TheMove { get; set; }

        [JsonProperty("version_group_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    public class Move2
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Other
    {
        [JsonProperty("dream_world", NullValueHandling = NullValueHandling.Ignore)]
        public DreamWorld DreamWorld { get; set; }

        [JsonProperty("home", NullValueHandling = NullValueHandling.Ignore)]
        public Home Home { get; set; }

        [JsonProperty("official-artwork", NullValueHandling = NullValueHandling.Ignore)]
        public OfficialArtwork OfficialArtwork { get; set; }

        [JsonProperty("showdown", NullValueHandling = NullValueHandling.Ignore)]
        public Showdown Showdown { get; set; }
    }

    public class Platinum
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class RedBlue
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_gray", NullValueHandling = NullValueHandling.Ignore)]
        public string BackGray { get; set; }

        [JsonProperty("back_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_gray", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontGray { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }

    public class RubySapphire
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }
    }

    public class Showdown
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Silver
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }

    public class Species
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public Other Other { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public Versions Versions { get; set; }
    }

    public class Stat
    {
        [JsonProperty("base_stat", NullValueHandling = NullValueHandling.Ignore)]
        public int? BaseStat { get; set; }

        [JsonProperty("effort", NullValueHandling = NullValueHandling.Ignore)]
        public int? Effort { get; set; }

        [JsonProperty("stat", NullValueHandling = NullValueHandling.Ignore)]
        public Stat TheStat { get; set; }
    }

    public class Stat2
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class Type
    {
        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public int? Slot { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Type TheType { get; set; }
    }

    public class Type2
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Version
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class VersionDetail
    {
        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rarity { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }
    }

    public class VersionGroup
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method", NullValueHandling = NullValueHandling.Ignore)]
        public MoveLearnMethod MoveLearnMethod { get; set; }

        [JsonProperty("version_group", NullValueHandling = NullValueHandling.Ignore)]
        public VersionGroup VersionGroup { get; set; }
    }

    public class Versions
    {
        [JsonProperty("generation-i", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationI GenerationI { get; set; }

        [JsonProperty("generation-ii", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationIi GenerationIi { get; set; }

        [JsonProperty("generation-iii", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationIii GenerationIii { get; set; }

        [JsonProperty("generation-iv", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationIv GenerationIv { get; set; }

        [JsonProperty("generation-v", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationV GenerationV { get; set; }

        [JsonProperty("generation-vi", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationVi GenerationVi { get; set; }

        [JsonProperty("generation-vii", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationVii GenerationVii { get; set; }

        [JsonProperty("generation-viii", NullValueHandling = NullValueHandling.Ignore)]
        public GenerationViii GenerationViii { get; set; }
    }

    public class XY
    {
        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontShinyFemale { get; set; }
    }

    public class Yellow
    {
        [JsonProperty("back_default", NullValueHandling = NullValueHandling.Ignore)]
        public string BackDefault { get; set; }

        [JsonProperty("back_gray", NullValueHandling = NullValueHandling.Ignore)]
        public string BackGray { get; set; }

        [JsonProperty("back_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string BackTransparent { get; set; }

        [JsonProperty("front_default", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontDefault { get; set; }

        [JsonProperty("front_gray", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontGray { get; set; }

        [JsonProperty("front_transparent", NullValueHandling = NullValueHandling.Ignore)]
        public string FrontTransparent { get; set; }
    }
}