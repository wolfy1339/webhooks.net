﻿namespace Octokit.Webhooks.Events;

using System.Text.Json.Serialization;
using JetBrains.Annotations;
using Octokit.Webhooks.Converter;

[PublicAPI]
[WebhookEventType(WebhookEventType.DeployKey)]
[JsonConverter(typeof(WebhookConverter<DeployKeyEvent>))]
public abstract record DeployKeyEvent : WebhookEvent
{
    [JsonPropertyName("key")]
    public Models.DeployKeyEvent.DeployKey Key { get; init; } = null!;
}
