using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Windows.Media;

namespace SLGridExample {
    public class CellForegroundConverter :IValueConverter {

        public SolidColorBrush FocusedBrush { get; set; }

        public SolidColorBrush NormalBrush { get; set; }

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            SelectionState state = (SelectionState)value;
            return state == SelectionState.Focused ? FocusedBrush : NormalBrush;
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new System.NotImplementedException();
        }
    }
}
