using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Audio_Player
{

    public partial class MainWindow : Window
    {

        private void PlayList_Click(object sender, RoutedEventArgs e)
        {
            SetVisibleMain();
        }

        private void AddToFolder_Click(object sender, RoutedEventArgs e)
        {
            SetVisibleFolderAdder();
        }
    }
    
}