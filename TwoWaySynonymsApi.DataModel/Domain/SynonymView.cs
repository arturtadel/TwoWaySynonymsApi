using TwoWaySynonymsApi.DataModel.Domain.Meta;

namespace TwoWaySynonymsApi.DataModel.Domain
{
    public class SynonymView : BaseModel<int>
    {
        public string Term { get; set; }
        public string Synonyms { get; set; }
    }
}
