using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using DiagramDesigner;

namespace DemoApp
{
    /// <summary>
    /// This is passed to the PopupWindow.xaml window, where a DataTemplate is used to provide the
    /// ContentControl with the look for this data. This class is also used to allow
    /// the popup to be cancelled without applying any changes to the calling ViewModel
    /// whos data will be updated if the PopupWindow.xaml window is closed successfully
    /// </summary>
    public class TextDesignerItemData : INPCBase
    {
        private string content = "test";
        private string color = "red";

        public TextDesignerItemData(string currentColor, string currentContent)
        {
            color = currentColor;
            content = currentContent;
        }

        private Brush _background;
        public Brush Background
        {
            get
            {
                return new SolidColorBrush(Colors.Orange);
            }

            set
            {
                _background = value;
                NotifyChanged("Background");
            }
        }

        public string Content
        {
            get { return content; }
            set
            {
                if (content != value)
                {
                    content = value;
                    NotifyChanged("Content");
                }
            }
        }

        public string Color
        {
            get { return  color; }
            set 
            {
                if(color != value)
                {
                    content= value;
                    NotifyChanged("Color");
                }
            }
        }
    }
}
