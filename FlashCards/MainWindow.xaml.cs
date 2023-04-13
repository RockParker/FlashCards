using System;
using System.Collections.Generic;
using FlashCards.Pages;
using System.Windows;
using FlashCards.Classes;

namespace FlashCards
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private EditingPage _editingpage;

        private IndexPage _indexpage;

        private PlayPage _playpage;
        private SelectionPage _selectionpage;

        private List<FlashCardData>? _list;
        
        
        
        
        //other pages here in the future
        public MainWindow()
        {
            InitializeComponent();

            _editingpage = new();
            _indexpage = new();
            _playpage = new();
            _selectionpage = new();

            _list = new();

            MainFrame.Navigate(_indexpage);

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(_selectionpage);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(_editingpage);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            if (spSettings.Visibility == Visibility.Collapsed)
            {
                spSettings.Visibility = Visibility.Visible;
                return;
            }

            spSettings.Visibility = Visibility.Collapsed;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(_indexpage);
        }

        public List<FlashCardData> GetData()
        {
            return  _list ?? new();
        }

        public static void SaveList(List<FlashCardData> list)
        {
            //do a thing here
            throw new NotImplementedException();
        }

        private void BtnFullscreen_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                return;
            }

            this.WindowState = WindowState.Maximized;
        }
    }
}
