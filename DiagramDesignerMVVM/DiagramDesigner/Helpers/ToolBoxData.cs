using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner.Helpers
{
    public class ToolBoxData
    {
        public string ImageUrl { get; private set; }
        public string Content { get; private set; }
        public string color { get; private set; }
        public Type Type { get; private set; }

        public ToolBoxData(string imageUrl, Type type)
        {
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        public ToolBoxData(string content, string color , Type type)
        {
            this.color = color;
            this.Content = content;
            this.Type = type;
        }
    }
}
