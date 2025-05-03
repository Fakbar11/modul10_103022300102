namespace jurnal10
{
    public class Movie(string title, string director, List<string> stars, string description)
    {
        public string? title { get; set; }

        public string? director { get; set; }

        public List<string>? stars { get; set; }

        public string? description  { get; set; }
    }
}
