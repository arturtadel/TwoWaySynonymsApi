namespace TwoWaySynonymsApi.Business.Dto
{
    public class SynonymDto : BaseDto<int>
    {
        public string Term { get; set; }
        public string Synonyms { get; set; }
    }
}
