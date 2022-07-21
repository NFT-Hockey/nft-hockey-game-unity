using Newtonsoft.Json;

namespace Near.Models.Extras
{
    public class GoalieStats
    {
        // Reflexes
        
        [JsonProperty("angles")]
        public uint Angles { get; set; }
        
        [JsonProperty("breakaway")]
        public uint Breakaway { get; set; }
        
        [JsonProperty("five_hole")]
        public uint FiveHole { get; set; }
        
        [JsonProperty("glove_side_high")]
        public uint GloveSideHigh { get; set; }
        
        [JsonProperty("glove_side_low")]
        public uint GloveSideLow { get; set; }
        
        [JsonProperty("stick_side_high")]
        public uint StickSideHigh { get; set; }
        
        [JsonProperty("stick_side_low")]
        public uint StickSideLow { get; set; }

        // Puck control
        
        [JsonProperty("passing")]
        public uint Passing { get; set; }
        
        [JsonProperty("poise")]
        public uint Poise { get; set; }
        
        [JsonProperty("poke_check")]
        public uint PokeCheck { get; set; }
        
        [JsonProperty("puck_playing")]
        public uint PuckPlaying { get; set; }
        
        [JsonProperty("rebound_control")]
        public uint ReboundControl { get; set; }
        
        [JsonProperty("recover")]
        public uint Recover { get; set; } 
        
        // Strength
        
        [JsonProperty("aggressiveness")] 
        public uint Aggressiveness { get; set; }
        
        [JsonProperty("agility")]
        public uint Agility { get; set; }
        
        [JsonProperty("durability")] 
        public uint Durability { get; set; } 
        
        [JsonProperty("endurance")]
        public uint Endurance { get; set; } 
        
        [JsonProperty("speed")] 
        public uint Speed { get; set; } 
        
        [JsonProperty("vision")]
        public uint Vision { get; set; } 
        
        [JsonProperty("morale")] 
        public uint Morale { get; set; }
    }
}