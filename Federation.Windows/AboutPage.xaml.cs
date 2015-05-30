using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Federation.WindowsUniversal {
    public partial class AboutPage : Page {
   //     readonly BackgroundWorker bgWorker = new BackgroundWorker();

        public AboutPage() {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            //bgWorker.DoWork += BgWorker_DoWork;
            //bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            //bgWorker.RunWorkerAsync();
        }

        private const int movePerTick = 1;
        private int numOpacities = 0;
        private const int maxPixelsBetweenRemoval = 30;
        private const int maxPixelsBetweenAltRemoval = 40;
        private int numPixelsBetween = 0;
        private bool alt = false;

       // private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
       //     spCredits.Margin = new Thickness(0, spCredits.Margin.Top - movePerTick, 0, 0);

       //     if (spCredits.Margin.Top <= 60) {
       //         if (spCredits.Children[numOpacities].Opacity > 0.0) {
       //             spCredits.Children[numOpacities].Opacity -= .1;
       //         } else {
       //             if (alt) {
       //                 if (maxPixelsBetweenAltRemoval == numPixelsBetween) {
       //                     numOpacities++;
       //                     numPixelsBetween = 0;
       //                     alt = false;
       //                 } else {
       //                     numPixelsBetween += movePerTick;
       //                 }
       //             } else {
       //                 if (maxPixelsBetweenRemoval == numPixelsBetween) {
       //                     numOpacities++;
       //                     numPixelsBetween = 0;
       //                     alt = true;
       //                 } else {
       //                     numPixelsBetween += movePerTick;
       //                 }
       //             }
       //         }

       //       //  if (numOpacities >= spCredits.Children.Count()) {
       //             //NavigationService.GoBack();
       //         //    return;
       //         //}
       //     }

       ////     bgWorker.RunWorkerAsync();
       // }

       // private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
       //     //Thread.Sleep(20);
       // }
    }
}