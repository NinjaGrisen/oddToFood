using System.ComponentModel.DataAnnotations;

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

        [Required, MaxLength(80)]
        //[DataType(DataType.Password)]
        [Display(Name = "Resturant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
