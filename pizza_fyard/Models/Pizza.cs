using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pizza_fyard.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string name { get; set; }
        [Display(Name = "Prix ($)")]
        public float price { get; set; }
        [Display(Name = "Végétarienne")]
        public bool vegan { get; set; }
        [Display(Name = "Ingrédients")]
        [JsonIgnore]
        public string ingredients { get; set; }

        [JsonPropertyName("ingredients")]
        public string[] ingredientsList
        {
            get
            {
                if ((ingredients == null) || (ingredients.Count() == 0))
                {
                    return null;
                }

                return ingredients.Split(", ");
            }
        }
    }
}
