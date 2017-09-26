namespace dotnetCoreMapper.Models
{
    /// <summary>
    /// Class representing a subset of Reddit post's "data" fields.
    /// </summary>
    class PostData
    {
        /// <summary>
        /// Domain the post is hosted on. 
        /// TBD: what if it's a self-post?
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Id of the post. 
        /// Can be used to create a hard-link or to fetch additional data about the post.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Total score (takes into account upvotes and downvotes).
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Author's title for the post.
        /// </summary>
        public string Title { get; set; }
    }
}
