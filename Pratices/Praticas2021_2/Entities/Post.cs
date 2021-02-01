using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas2021_2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = new List<Comments>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComments(Comments comment)
        {
            Comments.Add(comment);
        }
        public void RemoveCommenets(Comments comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (var item in Comments)
            {
                sb.AppendLine(item.Text);
            }
            return sb.ToString();
        }

    }
}
