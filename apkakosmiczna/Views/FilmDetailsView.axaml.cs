// FilmDetailsView.axaml.cs
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace apkakosmiczna.Views
{
    public partial class FilmDetailsView : UserControl
    {
        public FilmDetailsView()
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}