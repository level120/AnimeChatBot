namespace LaftelMcpServer.Models;

public class DailyModel
{
    public int id { get; set; }
    public string name { get; set; }
    public string img { get; set; }
    public string cropped_img { get; set; }
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
    public bool is_laftel_original { get; set; }
    public bool is_exclusive { get; set; }
    public bool is_uncensored { get; set; }
    public bool is_dubbed { get; set; }
    public bool is_avod { get; set; }
    public bool is_viewing { get; set; }
    public DateTime? latest_episode_created { get; set; }
    public DateTime? latest_published_datetime { get; set; }
    public bool is_episode_existed { get; set; }
    public bool is_expired { get; set; }
    public Highlight_Video highlight_video { get; set; }
    public string[] distributed_air_times { get; set; }
    public int distributed_air_time_sequence { get; set; }
}

public class Highlight_Video
{
    public string content_id { get; set; }
    public string dash_url { get; set; }
    public string hls_url { get; set; }
}

public class Image
{
    public string crop_ratio { get; set; }
    public string img_url { get; set; }
    public string option_name { get; set; }
}
