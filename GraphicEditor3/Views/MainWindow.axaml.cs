using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using GraphicsEditor.ViewModels;

namespace GraphicsEditor.Views {
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}