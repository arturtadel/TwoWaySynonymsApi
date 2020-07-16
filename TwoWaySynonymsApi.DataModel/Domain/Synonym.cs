using System.ComponentModel.DataAnnotations;
using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.DataModel.Domain
{
    public class Synonym : BaseModel<int>
    {
        [Required]
        public string Term { get; set; }
        [Required]
        public string Synonyms { get; set; }
    }
}
