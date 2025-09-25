using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthSeconds)
        {
            _title = title;
            _author = author;
            _lengthSeconds = lengthSeconds;
            _comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthSeconds()
        {
            return _lengthSeconds;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}