Imports Microsoft.VisualBasic
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows.Media

Namespace SLGridExample
	Public Class CellForegroundConverter
		Implements IValueConverter

		Private privateFocusedBrush As SolidColorBrush
		Public Property FocusedBrush() As SolidColorBrush
			Get
				Return privateFocusedBrush
			End Get
			Set(ByVal value As SolidColorBrush)
				privateFocusedBrush = value
			End Set
		End Property

		Private privateNormalBrush As SolidColorBrush
		Public Property NormalBrush() As SolidColorBrush
			Get
				Return privateNormalBrush
			End Get
			Set(ByVal value As SolidColorBrush)
				privateNormalBrush = value
			End Set
		End Property

		Public Function Convert(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim state As SelectionState = CType(value, SelectionState)
			Return If(state = SelectionState.Focused, FocusedBrush, NormalBrush)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As System.Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New System.NotImplementedException()
		End Function
	End Class
End Namespace
