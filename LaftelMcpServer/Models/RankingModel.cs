namespace LaftelMcpServer.Models;

public class RankingModel
{
    public int id { get; set; }
    public string name { get; set; }
    public string img { get; set; }
    public string cropped_img { get; set; }
    public bool is_adult { get; set; }
    public Image[] images { get; set; }
    public string[] genres { get; set; }
    public Highlight_Video highlight_video { get; set; }
    public bool is_laftel_only { get; set; }
    public bool is_laftel_original { get; set; }
    public bool is_uncensored { get; set; }
    public bool is_dubbed { get; set; }
    public bool is_avod { get; set; }
    public bool is_viewing { get; set; }
    public string content_rating { get; set; }
    public int rating { get; set; }
    public string rating_type { get; set; }
}
