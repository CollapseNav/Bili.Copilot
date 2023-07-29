﻿// Copyright (c) Bili Copilot. All rights reserved.
// <auto-generated />

namespace Bili.Copilot.Models.BiliBili.Player;

/// <summary>
/// 视频页面响应.
/// </summary>
public class VideoPageResponse : VideoBase
{
    /// <summary>
    /// 视频的 BvId.
    /// </summary>
    [JsonPropertyName("bvid")]
    public string Bvid { get; set; }

    [JsonPropertyName("aid")]
    public long Aid { get; set; }

    [JsonPropertyName("tid")]
    public int TagId { get; set; }

    [JsonPropertyName("tname")]
    public string TagName { get; set; }

    [JsonPropertyName("pic")]
    public string Cover { get; set; }

    [JsonPropertyName("ctime")]
    public int CreateTime { get; set; }

    [JsonPropertyName("desc")]
    public string Description { get; set; }

    [JsonPropertyName("state")]
    public int State { get; set; }

    [JsonPropertyName("owner")]
    public PublisherInfo Owner { get; set; }

    [JsonPropertyName("stat")]
    public VideoStatusInfo Stat { get; set; }

    [JsonPropertyName("cid")]
    public int Cid { get; set; }

    [JsonPropertyName("pages")]
    public List<SubVideo> SubVideos { get; set; }

    public class SubVideo
    {
        [JsonPropertyName("cid")]
        public int Cid { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("part")]
        public string Title { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }
    }
}