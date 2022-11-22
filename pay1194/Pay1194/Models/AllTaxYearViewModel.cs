using Microsoft.AspNetCore.Mvc.Rendering;
using Pay1194.Service;
using Pay1194.Service.Implementation;

namespace Pay1194.Models
{
    public class AllTaxYearViewModel
    {
        public int Id { get; set; }
        public List<SelectListItem> list { get; set; } 
    }
}
