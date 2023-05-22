using System;
using System.Net.Http.Headers;
using System.Web;

var handler = new HttpClientHandler { UseDefaultCredentials = true };

using (var httpClient = new HttpClient(handler))
{
    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

    var query = HttpUtility.ParseQueryString(string.Empty);

    query["week"] = "17";
    query["year"] = "2003";

    var builder = new UriBuilder("http://localhost:92")
    {
        Path = "/api/extract",
        Query = query.ToString()
    };

    Console.WriteLine(builder.Uri);
}

Console.ReadKey();