using System;
using System.Windows.Controls;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightApplication22 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            documentPreview1.Model.CreateDocument();
        }
    }
}
