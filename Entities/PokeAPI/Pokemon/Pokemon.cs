using Entities.Base;
using Entities.PokeAPI.Pokemon.Generations;
using Newtonsoft.Json;

namespace Entities.PokeAPI.Pokemon
{
    public class Pokemon : EntityBase
    {
        [JsonProperty("abilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Hability> Abilities { get; set; }

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