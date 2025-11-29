using System.Xml.Serialization;

namespace BlazorBootStrap.Client.Models;

[XmlRoot("rss")]
public class GoogleTrendsRss
{
  [XmlElement("channel")]
    public Channel? Channel { get; set; }
}

public class Channel
{
    [XmlElement("title")]
    public string? Title { get; set; }

    [XmlElement("link")]
    public string? Link { get; set; }

    [XmlElement("item")]
    public List<TrendItem>? Items { get; set; }
}

public class TrendItem
{
    [XmlElement("title")]
    public string? Title { get; set; }

    [XmlElement("ht:approx_traffic", Namespace = "http://www.google.com/trends/hottrends")]
    public string? ApproxTraffic { get; set; }

    [XmlElement("description")]
    public string? Description { get; set; }

    [XmlElement("link")]
    public string? Link { get; set; }

    [XmlElement("pubDate")]
    public string? PubDate { get; set; }

[XmlElement("ht:picture", Namespace = "http://www.google.com/trends/hottrends")]
    public string? Picture { get; set; }

    [XmlElement("ht:picture_source", Namespace = "http://www.google.com/trends/hottrends")]
    public string? PictureSource { get; set; }

    [XmlElement("ht:news_item", Namespace = "http://www.google.com/trends/hottrends")]
  public List<NewsItem>? NewsItems { get; set; }
}

public class NewsItem
{
    [XmlElement("ht:news_item_title", Namespace = "http://www.google.com/trends/hottrends")]
    public string? Title { get; set; }

    [XmlElement("ht:news_item_snippet", Namespace = "http://www.google.com/trends/hottrends")]
    public string? Snippet { get; set; }

    [XmlElement("ht:news_item_url", Namespace = "http://www.google.com/trends/hottrends")]
  public string? Url { get; set; }

    [XmlElement("ht:news_item_source", Namespace = "http://www.google.com/trends/hottrends")]
    public string? Source { get; set; }
}
