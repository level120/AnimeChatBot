using LaftelMcpServer.Models;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Net.Http.Json;

namespace LaftelMcpServer.Tools;

internal class LaftelApiTools
{
    private const string ApiHost = "https://api.laftel.net/api";
    private const string DailyApiHost = $"{ApiHost}/search/v2/daily";
    private const string SearchApiHost = $"{ApiHost}/search/v3/keyword/?keyword={{0}}&viewing_only={{1}}&offset={{2}}&size={{3}}";
    private const string RankingApiHost = $"{ApiHost}/home/v1/recommend/ranking/?type=4hour";

    private readonly HttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="LaftelApiTools"/> class.
    /// </summary>
    /// <param name="httpClient">httpClient</param>
    public LaftelApiTools(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    [McpServerTool]
    [Description("요일별 애니메이션 정보를 가져옵니다.")]
    public async Task<DailyModel[]> GetAnimeByDayOfWeekAsync()
    {
        var result =  await _httpClient.GetFromJsonAsync<DailyModel[]>(DailyApiHost).ConfigureAwait(false);

        return result;
    }

    [McpServerTool]
    [Description("키워드를 입력받아 그에 맞는 애니메이션 정보를 가져옵니다.")]
    public async Task<SearchModel> SearchAnimeByKeywordAsync(
        [Description("검색 키워드")] string keyword = "",
        [Description("현재 방영중인 것만 보기")] bool viewingOnly = true)
    {
        var result = await _httpClient.GetFromJsonAsync<SearchModel>(
                string.Format(SearchApiHost, keyword, viewingOnly, 0, 5))
            .ConfigureAwait(false);

        return result;
    }

    [McpServerTool]
    [Description("최근 4시간동안의 애니메이션 랭킹 정보를 가져옵니다.")]
    public async Task<RankingModel[]> GetAnimeRankingByTimeRangeAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<RankingModel[]>(RankingApiHost).ConfigureAwait(false);

        return result;
    }
}