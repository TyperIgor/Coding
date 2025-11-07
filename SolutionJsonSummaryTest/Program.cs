// See https://aka.ms/new-console-template for more information




using System.Text.Json;

string s = "{\"\"runId\"\":\"\"R1\"\",\"\"testName\"\":\"\"Login.Valid\"\",\"\"status\"\":\"\"Passed\"\",\"\"durationMs\"\":500}\r\n";

var result = GetJSonFromSTDIN.ParseTheJson(s);

Console.WriteLine("json test", result.ToString());



public class GetJSonFromSTDIN
{
    public static JsonAttributeEntity[] ParseTheJson(string parsedJson)
    {
        var deserialized = JsonSerializer.Deserialize<JsonAttributeEntity[]>(parsedJson);

        return deserialized;
    }
}


public class JsonAttributeEntity
{
    public int RunId { get; set; }

    public string testName { get; set; }

    public string Login;

    public string status { get; set; }

    public int durationMs { get; set; }
}
