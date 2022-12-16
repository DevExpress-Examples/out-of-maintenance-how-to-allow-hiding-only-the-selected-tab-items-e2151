Imports System.Windows
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core
Imports DXExample.DemoData

Namespace DXTabControl_AllowHideSelectedItem

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.tabControl.ItemsSource = Invoice.GetData()
        End Sub

        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As TabControlSelectionChangedEventArgs)
            Dim oldItem As DXTabItem = Me.tabControl.GetTabItem(e.OldSelectedIndex)
            Dim newItem As DXTabItem = Me.tabControl.GetTabItem(Me.tabControl.SelectedIndex)
            If oldItem IsNot Nothing Then oldItem.AllowHide = DefaultBoolean.Default
            If newItem IsNot Nothing Then newItem.AllowHide = DefaultBoolean.True
        End Sub
    End Class
End Namespace
