using System;
using System.Collections.Generic;
using OdeToFood.Entities;


namespace OdeToFood.Services
{
    public interface IFriendsData
    {
        IEnumerable<Friend> GetAll();
    }

    public class InMemoryFriendsData : IFriendsData
    {
        public InMemoryFriendsData(IUserData userData)
        {
            var user1 = userData.Get("Alva");
            var user2 = userData.Get("NinjaGrisen");

            if (user1 == null )
            {
                return;
            }

            user1.Id = "1";
            user2.Id = "2";

            _friends = new List<Friend>
            {
                new Friend { FriendUser = userData.Get("Alva"),
                            Matches = new List<Match>
                            {
                                new Match {Id = 0, Game = "Fifa", Played = DateTime.Now, FriendScore = 2 , PlayerScore = 0 },
                                new Match {Id = 1, Game = "Fifa", Played = DateTime.Now.AddDays(-1), FriendScore = 3 , PlayerScore = 1 },
                                new Match {Id = 2, Game = "Fifa", Played = DateTime.Now.AddDays(-2), FriendScore = 4 , PlayerScore = 2 },
                            }
                },
                new Friend { FriendUser = userData.Get("NinjaGrisen"),
                            Matches = new List<Match>
                            {
                                new Match {Id = 0, Game = "Dota2", Played = DateTime.Now, FriendScore = 2 , PlayerScore = 0 },
                                new Match {Id = 1, Game = "Dota2", Played = DateTime.Now.AddDays(-1), FriendScore = 3 , PlayerScore = 1 },
                                new Match {Id = 2, Game = "Dota2", Played = DateTime.Now.AddDays(-2), FriendScore = 4 , PlayerScore = 2 },
                            }
                }
            };
        }

        public IEnumerable<Friend> GetAll()
        {
            return _friends;
        }

        static List<Friend> _friends;
    }
}
