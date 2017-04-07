using OdeToFood.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OdeToFood.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();

        Resturant Get(int id);
        void Add(Resturant resturant);
    }

    public class InMemoryResturantData : IResturantData
    {
        static InMemoryResturantData()
        {
            _resturants = new List<Resturant>
            {
                new Resturant { Id = 1, Name = "Food to too" },
                new Resturant { Id = 2, Name = "Twatters" },
                new Resturant { Id = 3, Name = "Niplets" }
            };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _resturants;
        }

        public Resturant Get(int id)
        {
            return _resturants.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Resturant newResturant)
        {
            newResturant.Id = _resturants.Max(r => r.Id) + 1;

            _resturants.Add(newResturant);
        }

        static List<Resturant> _resturants;
    }
}
