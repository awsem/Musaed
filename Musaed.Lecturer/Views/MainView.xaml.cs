using Musaed.Lecturer.Dialogs;
using Musaed.Lecturer.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Musaed.Lecturer.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        private MusaedService _musaedService;
        public MainView()
        {
            this.InitializeComponent();
            _musaedService = new MusaedService();
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            var co = await _musaedService.GetCoursesAsync();

            foreach (var item in co)
            {
                vm.Courses.Add(item);
            }
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await new NewCourseDialog().ShowAsync();
        }

        private async void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            vm.Courses.Clear();
            var co = await _musaedService.GetCoursesAsync();

            foreach (var item in co)
            {
                vm.Courses.Add(item);
            }
        }
    }
}
