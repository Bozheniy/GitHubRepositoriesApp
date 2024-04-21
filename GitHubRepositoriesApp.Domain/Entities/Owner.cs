
namespace GitHubRepositoriesApp.Domain.Entities
{
    public class Owner
    {
        [Newtonsoft.Json.JsonProperty("login")]
        public string Login { get; set; }

        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("node_id")]
        public string NodeId { get; set; }

        [Newtonsoft.Json.JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}
