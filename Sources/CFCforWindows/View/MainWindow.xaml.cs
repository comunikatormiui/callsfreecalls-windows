using CFCforWindows.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CFCforWindows.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            AppVM.Instance.Initialize();

            _viewModel = new MainVM();
            DataContext = _viewModel;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            try
            {
                DragMove();
            }
            catch (Exception ex)
            {
                ////Logger.Instance.WriteError("MainWindow::OnMouseLeftButtonDown", "Drag move exception", ex);
            }
        }
    }
}