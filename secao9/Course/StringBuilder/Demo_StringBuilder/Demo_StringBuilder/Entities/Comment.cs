using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_StringBuilder.Entities
{
    class Comment
    {
        public string text { get; set; }
        // construtores
        public Comment()
        {
        }

        public Comment(string text)
        {
            this.text = text;
        }
    }
}
