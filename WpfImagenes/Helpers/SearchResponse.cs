﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace WpfImagenes.Helpers
{
    public class SearchResponse
    {
        [JsonProperty("data")]
        public List<Gif> Data { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public partial class Gif
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("bitly_gif_url")]
        public Uri BitlyGifUrl { get; set; }

        [JsonProperty("bitly_url")]
        public Uri BitlyUrl { get; set; }

        [JsonProperty("embed_url")]
        public Uri EmbedUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("source_tld")]
        public string SourceTld { get; set; }

        [JsonProperty("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonProperty("is_sticker")]
        public long IsSticker { get; set; }

        [JsonProperty("import_datetime")]
        public DateTimeOffset ImportDatetime { get; set; }

        [JsonProperty("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("analytics_response_payload")]
        public string AnalyticsResponsePayload { get; set; }

        [JsonProperty("analytics")]
        public Analytics Analytics { get; set; }

        [JsonProperty("alt_text")]
        public string AltText { get; set; }
    }

    public partial class Analytics
    {
        [JsonProperty("onload")]
        public Onclick Onload { get; set; }

        [JsonProperty("onclick")]
        public Onclick Onclick { get; set; }

        [JsonProperty("onsent")]
        public Onclick Onsent { get; set; }
    }

    public partial class Onclick
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("original")]
        public FixedHeight Original { get; set; }

        [JsonProperty("downsized")]
        public The480_WStill Downsized { get; set; }

        [JsonProperty("downsized_large")]
        public The480_WStill DownsizedLarge { get; set; }

        [JsonProperty("downsized_medium")]
        public The480_WStill DownsizedMedium { get; set; }

        [JsonProperty("downsized_small")]
        public DownsizedSmall DownsizedSmall { get; set; }

        [JsonProperty("downsized_still")]
        public The480_WStill DownsizedStill { get; set; }

        [JsonProperty("fixed_height")]
        public FixedHeight FixedHeight { get; set; }

        [JsonProperty("fixed_height_downsampled")]
        public FixedHeight FixedHeightDownsampled { get; set; }

        [JsonProperty("fixed_height_small")]
        public FixedHeight FixedHeightSmall { get; set; }

        [JsonProperty("fixed_height_small_still")]
        public The480_WStill FixedHeightSmallStill { get; set; }

        [JsonProperty("fixed_height_still")]
        public The480_WStill FixedHeightStill { get; set; }

        [JsonProperty("fixed_width")]
        public FixedHeight FixedWidth { get; set; }

        [JsonProperty("fixed_width_downsampled")]
        public FixedHeight FixedWidthDownsampled { get; set; }

        [JsonProperty("fixed_width_small")]
        public FixedHeight FixedWidthSmall { get; set; }

        [JsonProperty("fixed_width_small_still")]
        public The480_WStill FixedWidthSmallStill { get; set; }

        [JsonProperty("fixed_width_still")]
        public The480_WStill FixedWidthStill { get; set; }

        [JsonProperty("looping")]
        public Looping Looping { get; set; }

        [JsonProperty("original_still")]
        public The480_WStill OriginalStill { get; set; }

        [JsonProperty("original_mp4")]
        public DownsizedSmall OriginalMp4 { get; set; }

        [JsonProperty("preview")]
        public DownsizedSmall Preview { get; set; }

        [JsonProperty("preview_gif")]
        public The480_WStill PreviewGif { get; set; }

        [JsonProperty("preview_webp")]
        public The480_WStill PreviewWebp { get; set; }

        [JsonProperty("hd", NullValueHandling = NullValueHandling.Ignore)]
        public DownsizedSmall Hd { get; set; }

        [JsonProperty("480w_still")]
        public The480_WStill The480WStill { get; set; }
    }

    public partial class The480_WStill
    {
        [JsonProperty("height")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Height { get; set; }

        [JsonProperty("width")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Width { get; set; }

        [JsonProperty("size")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Size { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class DownsizedSmall
    {
        [JsonProperty("height")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Height { get; set; }

        [JsonProperty("width")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Width { get; set; }

        [JsonProperty("mp4_size")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public Uri Mp4 { get; set; }
    }

    public partial class FixedHeight
    {
        [JsonProperty("height")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Height { get; set; }

        [JsonProperty("width")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Width { get; set; }

        [JsonProperty("size")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Size { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("mp4_size", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Mp4Size { get; set; }

        [JsonProperty("mp4", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Mp4 { get; set; }

        [JsonProperty("webp_size")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WebpSize { get; set; }

        [JsonProperty("webp")]
        public Uri Webp { get; set; }

        [JsonProperty("frames", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Frames { get; set; }

        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }
    }

    public partial class Looping
    {
        [JsonProperty("mp4_size")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public Uri Mp4 { get; set; }
    }

    public partial class User
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("banner_image")]
        public string BannerImage { get; set; }

        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        [JsonProperty("profile_url")]
        public Uri ProfileUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("instagram_url")]
        public Uri InstagramUrl { get; set; }

        [JsonProperty("website_url")]
        public Uri WebsiteUrl { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, WpfImagenes.Helpers.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, WpfImagenes.Helpers.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}



