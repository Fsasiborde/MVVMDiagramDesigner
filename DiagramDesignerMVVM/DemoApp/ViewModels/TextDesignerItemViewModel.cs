using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagramDesigner;
using System.Windows.Input;
using System.Windows.Media;


namespace DemoApp
{
    public class TextDesignerItemViewModel : DesignerItemViewModelBase, ISupportDataChanges
    {
        private IUIVisualizerService visualiserService;

        public TextDesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top, string content, string color)
            : base(id, parent, left, top)
        {

            this.Content = content;
            this.Color = color;
            this.Background = new SolidColorBrush(Colors.Orange);
            Init();
        }

        public TextDesignerItemViewModel(int id, IDiagramViewModel parent, double left, double top, double itemWidth, double itemHeight, string content, string color)
             : base(id, parent, left, top, itemWidth, itemHeight)
        {

            this.Content = content;
            this.Color = color;
            this.Background = new SolidColorBrush(Colors.Orange);
            Init();
        }

        public TextDesignerItemViewModel()
        {
            this.ItemWidth = 100;
            this.ItemHeight = 100;
            this.Background = new SolidColorBrush(Colors.Orange);
            Init();
        }

        public String Content { get; set; }
        public String Color { get; set; }
        public Brush Background { get; set; }
        public ICommand ShowDataChangeWindowCommand { get; private set; }

        public void ExecuteShowDataChangeWindowCommand(object parameter)
        {
            TextDesignerItemData data = new TextDesignerItemData(Content, Color);
            if (visualiserService.ShowDialog(data) == true)
            {
                this.Content = data.Content;
                this.Color = data.Color;
                this.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void Init()
        {
            visualiserService = ApplicationServicesProvider.Instance.Provider.VisualizerService;
            ShowDataChangeWindowCommand = new SimpleCommand(ExecuteShowDataChangeWindowCommand);
            this.ShowConnectors = false;
        }
    }
}
