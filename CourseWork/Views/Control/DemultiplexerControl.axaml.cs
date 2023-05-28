using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace CourseWork.Views.Control
{
    public class DemultiplexerControl : TemplatedControl
    {
        public static readonly StyledProperty<bool> FocusOnElementProperty =
            AvaloniaProperty.Register<DemultiplexerControl, bool>("FocusOnElement");

        public bool FocusOnElement
        {
            get => GetValue(FocusOnElementProperty);
            set => SetValue(FocusOnElementProperty, value);
        }
    }
}
