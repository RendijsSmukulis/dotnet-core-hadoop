namespace dotnetCoreMapper.Models
{
    /// <summary>
    /// Class representing a part of a Reddit post. 
    /// We currently only care about the data in the "data" field.
    /// </summary>
    class RedditPost
    {
        public PostData Data { get; set; }
    }
}
