using System;

namespace OdeToFood.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public string Game { get; set; }
        public int PlayerScore { get; set; }
        public int FriendScore { get; set; }
        public DateTime Played { get; set; }
    }
}
