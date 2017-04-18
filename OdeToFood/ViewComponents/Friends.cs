using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.ViewComponents
{
    public class Friends : ViewComponent
    {
        //private IFriendsData _friends;

        //public Friends(IFriendsData friends)
        //{
        //    _friends = friends;
        //}

        public IViewComponentResult Invoke(IUserData userData)
        {
            //var model = new List<Friend>
            //{
            //    new Friend { FriendUser = userData.Get("Alva"),
            //                Matches = new List<Match>
            //                {
            //                    new Match {Id = 0, Game = "Fifa", Played = DateTime.Now, FriendScore = 2 , PlayerScore = 0 },
            //                    new Match {Id = 1, Game = "Fifa", Played = DateTime.Now.AddDays(-1), FriendScore = 3 , PlayerScore = 1 },
            //                    new Match {Id = 2, Game = "Fifa", Played = DateTime.Now.AddDays(-2), FriendScore = 4 , PlayerScore = 2 },
            //                }
            //    },
            //    new Friend { FriendUser = userData.Get("NinjaGrisen"),
            //                Matches = new List<Match>
            //                {
            //                    new Match {Id = 0, Game = "Dota2", Played = DateTime.Now, FriendScore = 2 , PlayerScore = 0 },
            //                    new Match {Id = 1, Game = "Dota2", Played = DateTime.Now.AddDays(-1), FriendScore = 3 , PlayerScore = 1 },
            //                    new Match {Id = 2, Game = "Dota2", Played = DateTime.Now.AddDays(-2), FriendScore = 4 , PlayerScore = 2 },
            //                }
            //    }
            //};
            var model = new List<Match>
                            {
                                new Match {Id = 0, Game = "Fifa", Played = DateTime.Now, FriendScore = 2 , PlayerScore = 0 },
                                new Match {Id = 1, Game = "Dota 2", Played = DateTime.Now.AddDays(-1), FriendScore = 3 , PlayerScore = 1 },
                                new Match {Id = 2, Game = "Fifa", Played = DateTime.Now.AddDays(-2), FriendScore = 4 , PlayerScore = 2 },
                            };

            return View("Default", model.Where(g => g.Game == "Fifa").ToList());
        }
    }
}
