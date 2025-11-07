// See https://aka.ms/new-console-template for more information




using SolutionJSonTest;

string s = "{\"\"runId\"\":\"\"R1\"\",\"\"testName\"\":\"\"Login.Valid\"\",\"\"status\"\":\"\"Passed\"\",\"\"durationMs\"\":500}\r\n";

var result =  GetJSonFromSTDIN.ParseTheJson(s);

Console.WriteLine("json test", result.ToString());


