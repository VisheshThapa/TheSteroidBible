namespace SteroidBible.Methods
{
    public class Root
    {
        public string Name { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public List<string>? Weeks { get; set; }  
        public List<List<List<string>>>? Cycle { get; set; }
    }

}
