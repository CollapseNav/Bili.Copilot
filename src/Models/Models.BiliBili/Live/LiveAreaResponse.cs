// Copyright (c) Bili Copilot. All rights reserved.

using System.Collections.Generic;

namespace Bili.Copilot.Models.BiliBili;

/// <summary>
/// ֱ��������Ӧ���.
/// </summary>
public class LiveAreaResponse
{
    /// <summary>
    /// �б�.
    /// </summary>
    [JsonPropertyName("list")]
    public List<LiveAreaGroup> List { get; set; }
}
