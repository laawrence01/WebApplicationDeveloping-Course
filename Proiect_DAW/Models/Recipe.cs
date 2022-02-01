using System;
using System.ComponentModel.DataAnnotations;

namespace Proiect_DAW.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public decimal Cooking_time { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
