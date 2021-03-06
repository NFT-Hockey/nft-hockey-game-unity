using System.Collections.Generic;

namespace Near.Models
{
    public class NFT
    {
        public string token_id { get; set; }
        public string owner_id { get; set; }
        public Metadata metadata { get; set; }
        public dynamic approved_accounts_ids { get; set; }
        public Dictionary<string, double> royalty { get; set; }
        public dynamic token_type { get; set; }
    }
}