using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BonayogDianaMae.APIActivity.Pages
{
    
    public class CardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class CardViewModel
    {
        public string? Name { get; set; }

        public string? ManaCost { get; set; }

        public decimal? CMC { get; set; }    
        public string? Colors { get; set; }

        public string? Type { get; set; }

        public string? Rarity { get; set; }
        
        public string? SetName { get; set; }

        public string? Text { get; set; }

        public int? Loyalty { get; set; }
    }
    
}
