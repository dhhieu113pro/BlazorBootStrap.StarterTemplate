namespace BlazorBootStrap.Client;

public class GoogleTrendClient(HttpClient httpClient)
{
    private bool _isBrowser = OperatingSystem.IsBrowser();

    public async Task<string> GetTrendsAsync(string geo)
    {
        return _isBrowser ?
              await httpClient.GetStringAsync($"/api/google-trends?geo={geo}")
            : await httpClient.GetStringAsync($"https://trends.google.com.vn/trending/rss?geo={geo}");
    }
}
