namespace LocadorManager_Api.Model.Proprietarios
{
    public class Root
    {
        public string status { get; set; }
        public string session { get; set; }
        public string msg { get; set; }
        public List<Proprietario> data { get; set; }
        public string executiontime { get; set; }
    }
}
