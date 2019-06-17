using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDFViewerPoC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFViewerPage : ContentPage
    {
        public PDFViewerPage()
        {
            InitializeComponent();
            InitializePdfViewerResource();
        }

        private void InitializePdfViewerResource()
        {
            pdfViewerControl.InputFileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PDFViewerPoC.xxx.pdf");
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            pdfViewerControl.Unload();
        }
    }
}