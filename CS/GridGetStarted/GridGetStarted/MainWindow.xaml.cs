using Microsoft.UI.Xaml;

namespace GridGetStarted {
    public sealed partial class MainWindow : Window {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainWindow() {
            this.InitializeComponent();
        }
    }
}
