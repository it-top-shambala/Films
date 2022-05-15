namespace Films.Lib;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Films
{
    public List<Doc> Docs { get; set; }
    public int Total { get; set; }
    public int Limit { get; set; }
    public int Page { get; set; }
    public int Pages { get; set; }
}

public class Doc
{
    public ExternalId ExternalId { get; set; }
    public Poster Poster { get; set; }
    public Rating Rating { get; set; }
    public Votes Votes { get; set; }
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? Year { get; set; }
    public string AlternativeName { get; set; }
    public object EnName { get; set; }
    public int? MovieLength { get; set; }
    public List<Name> Names { get; set; }
    public string ShortDescription { get; set; }
}

public class ExternalId
{
    public string Id { get; set; }
    public string Imdb { get; set; }
}

public class Name
{
    public string Id { get; set; }
    public string Name_ { get; set; }
}

public class Poster
{
    public string Id { get; set; }
    public string Url { get; set; }
    public string PreviewUrl { get; set; }
}

public class Rating
{
    public string Id { get; set; }
    public double Kp { get; set; }
    public double Imdb { get; set; }
    public int FilmCritics { get; set; }
    public int RussianFilmCritics { get; set; }
    public double Await { get; set; }
}

public class Votes
{
    public string Id { get; set; }
    public int Kp { get; set; }
    public int Imdb { get; set; }
    public int FilmCritics { get; set; }
    public int RussianFilmCritics { get; set; }
    public int Await { get; set; }
}

