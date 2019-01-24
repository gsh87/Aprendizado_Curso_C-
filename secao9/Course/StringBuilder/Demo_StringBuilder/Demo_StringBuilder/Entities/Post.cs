﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_StringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string title { get; set; }
        public string Content { get; set; }
        public int likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        // construtores
        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            this.title = title;
            Content = content;
            this.likes = likes;
        }
        // metodos
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.Append(likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.text);
            }
            return sb.ToString();
        }
    }
}
