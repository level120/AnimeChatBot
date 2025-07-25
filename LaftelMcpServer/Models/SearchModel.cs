namespace LaftelMcpServer.Models;

public class SearchModel
{
    public int count { get; set; }
    public Result[] results { get; set; }
    public string next { get; set; }
}

public class Result
{
    public int id { get; set; }
    public string name { get; set; }
    public string img { get; set; }
    public string cropped_img { get; set; }
    public string home_img { get; set; }
    public string home_cropped_img { get; set; }
    public Image[] images { get; set; }
    public string content_rating { get; set; }
    public int rating { get; set; }
    public string rating_type { get; set; }
    public bool is_adult { get; set; }
    public bool is_ending { get; set; }
    public string[] genres { get; set; }
    public string medium { get; set; }
    public string distributed_air_time { get; set; }
    public bool is_laftel_only { get; set; }
    public bool is_uncensored { get; set; }
    public bool is_dubbed { get; set; }
    public bool is_avod { get; set; }
    public bool is_viewing { get; set; }
    public DateTime latest_episode_created { get; set; }
    public DateTime latest_published_datetime { get; set; }
    public bool is_episode_existed { get; set; }
    public bool is_expired { get; set; }
    public Highlight_Video highlight_video { get; set; }
    public bool is_laftel_original { get; set; }
    public bool is_exclusive { get; set; }
}
