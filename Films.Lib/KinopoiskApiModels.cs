namespace Films.Lib;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class FilmsInfo
{
    public List<Doc> docs { get; set; }
    public int total { get; set; }
    public int limit { get; set; }
    public int page { get; set; }
    public int pages { get; set; }
}

public class Doc
{
    public ExternalId ExternalId { get; set; }
    public Poster poster { get; set; }
    public Rating rating { get; set; }
    public Votes votes { get; set; }
    public int id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int? year { get; set; }
    public string alternativeName { get; set; }
    public object enName { get; set; }
    public int? movieLength { get; set; }
    public List<Name> names { get; set; }
    public string shortDescription { get; set; }
}

public class ExternalId
{
    public string _id { get; set; }
    public string imdb { get; set; }
}

public class Name
{
    public string _id { get; set; }
    public string name { get; set; }
}

public class Poster
{
    public string _id { get; set; }
    public string url { get; set; }
    public string previewUrl { get; set; }
}

public class Rating
{
    public string _id { get; set; }
    public double kp { get; set; }
    public double imdb { get; set; }
    public int filmCritics { get; set; }
    public int russianFilmCritics { get; set; }
    public double await { get; set; }
}



public class Votes
{
    public string _id { get; set; }
    public int kp { get; set; }
    public int imdb { get; set; }
    public int filmCritics { get; set; }
    public int russianFilmCritics { get; set; }
    public int await { get; set; }
}

