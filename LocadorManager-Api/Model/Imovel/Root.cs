namespace LocadorManager_Api.Model.Imovel
{
    public class Root
    {
        public string status { get; set; }
        public string session { get; set; }
        public string msg { get; set; }
        public List<Imovel> data { get; set; }
        public string executiontime { get; set; }
    }
}
