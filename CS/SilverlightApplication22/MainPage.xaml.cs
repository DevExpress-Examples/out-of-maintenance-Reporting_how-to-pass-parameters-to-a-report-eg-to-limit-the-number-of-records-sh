using System.Windows.Controls;
// ...

namespace SilverlightApplication22 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            documentPreview1.Model.CreateDocument();
        }
    }
}
