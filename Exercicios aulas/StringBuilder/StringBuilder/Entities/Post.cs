﻿using System;
using System.Collections.Generic;
using System.Text;


namespace String_Builder.Entities
{
    class Post
    {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        // propriedade List declarada e instânciada
        public List<Comment> Comments { get; set; } = new List<Comment>();


        // construtor padrão sem argumentos
        public Post()
        {

        }

        // construtor com argumentos

        public Post(DateTime moment,  string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        // operações em classes
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
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:MM:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }

}
