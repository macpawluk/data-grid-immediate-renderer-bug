using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication.Models;

namespace AvaloniaApplication
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var dataGrid = this.FindControl<DataGrid>("dataGrid");

            var collectionView = new DataGridCollectionView(Countries.All);
            dataGrid.Items = collectionView;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}