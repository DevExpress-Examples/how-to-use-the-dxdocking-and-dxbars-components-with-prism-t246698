Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.NavBar
Imports System.ComponentModel.Composition

Namespace NavBarAndPrism.Views
	<Export>
	Partial Public Class ModuleAView
		Inherits NavBarGroup

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
