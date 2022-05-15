using System.Net;
using System.Text.Json;

namespace Films.Lib;

public static class KinopoiskApi
{
    public static FilmsInfo SearchFilms(string name)
    {
        var str = $"https://api.kinopoisk.dev/movie?token=ZQQ8GMN-TN54SGK-NB3MKEC-ZKB8V06&search={name}&field=name&isStrict=false";
        using var webStream = WebRequest.Create(str).GetResponse().GetResponseStream();
        using var stream = new StreamReader(webStream);
        var s = stream.ReadToEnd();
        var result = JsonSerializer.Deserialize<FilmsInfo>(s);
        return result;
    }
}