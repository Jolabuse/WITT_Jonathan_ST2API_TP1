namespace IntroCex5
{
    public class TimeSery
    {
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double volume { get; set; }
        public object market_cap { get; set; }
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public double price_score { get; set; }
        public double social_impact_score { get; set; }
        public double correlation_rank { get; set; }
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }
        public int alt_rank_30d { get; set; }
        public double alt_rank_hour_average { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public double price_btc { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public object market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public double percent_change_24h { get; set; }
    }
}