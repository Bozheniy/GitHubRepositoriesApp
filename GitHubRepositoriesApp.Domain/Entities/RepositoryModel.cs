

namespace GitHubRepositoriesApp.Domain.Entities
{
    public class RepositoryModel
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("node_id")]
        public string NodeId { get; set; }

        [Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("full_name")]
        public string FullName { get; set; }

        [Newtonsoft.Json.JsonProperty("_private")]
        public bool Private { get; set; }

        [Newtonsoft.Json.JsonProperty("owner")]
        public Owner Owner { get; set; }

        [Newtonsoft.Json.JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("description")]
        public object Description { get; set; }

        [Newtonsoft.Json.JsonProperty("fork")]
        public bool Fork { get; set; }

        [Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; }

        [Newtonsoft.Json.JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("teams_url")]
        public string TeamsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("hooks_url")]
        public string HooksUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("tags_url")]
        public string TagsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("languages_url")]
        public string LanguagesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("stargazers_url")]
        public string StargazersUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("contributors_url")]
        public string ContributorsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("subscribers_url")]
        public string SubscribersUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("subscription_url")]
        public string SubscriptionUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("merges_url")]
        public string MergesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("downloads_url")]
        public string DownloadsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("deployments_url")]
        public string DeploymentsUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("pushed_at")]
        public DateTime PushedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("git_url")]
        public string GitUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("clone_url")]
        public string CloneUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("svn_url")]
        public string SvnUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("homepage")]
        public object Homepage { get; set; }

        [Newtonsoft.Json.JsonProperty("size")]
        public int Size { get; set; }

        [Newtonsoft.Json.JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        [Newtonsoft.Json.JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        [Newtonsoft.Json.JsonProperty("language")]
        public string Language { get; set; }

        [Newtonsoft.Json.JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [Newtonsoft.Json.JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        [Newtonsoft.Json.JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        [Newtonsoft.Json.JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [Newtonsoft.Json.JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        [Newtonsoft.Json.JsonProperty("has_discussions")]
        public bool HasDiscussions { get; set; }

        [Newtonsoft.Json.JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        [Newtonsoft.Json.JsonProperty("mirror_url")]
        public object MirrorUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("archived")]
        public bool Archived { get; set; }

        [Newtonsoft.Json.JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [Newtonsoft.Json.JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [Newtonsoft.Json.JsonProperty("license")]
        public object License { get; set; }

        [Newtonsoft.Json.JsonProperty("allow_forking")]
        public bool AllowForking { get; set; }

        [Newtonsoft.Json.JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }

        [Newtonsoft.Json.JsonProperty("topics")]
        public object[] Topics { get; set; }

        [Newtonsoft.Json.JsonProperty("visibility")]
        public string Visibility { get; set; }

        [Newtonsoft.Json.JsonProperty("forks")]
        public int Forks { get; set; }

        [Newtonsoft.Json.JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        [Newtonsoft.Json.JsonProperty("watchers")]
        public int Watchers { get; set; }

        [Newtonsoft.Json.JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }
}
