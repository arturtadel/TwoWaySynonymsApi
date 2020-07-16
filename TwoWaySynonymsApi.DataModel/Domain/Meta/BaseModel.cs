using System.ComponentModel.DataAnnotations;

namespace TwoWaySynonymsApi.DataModel.Domain.Meta
{
    public class BaseModel<TKey>
    {
        [Key]
        public TKey Id { get; set; }
        public bool Deleted { get; set; }
    }
}
