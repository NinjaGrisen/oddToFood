namespace OdeToFood.Entities
{

    public enum CuisineType
    {
        None,
        Italian,
        French,
        Swedish
    }
    public class Resturant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
