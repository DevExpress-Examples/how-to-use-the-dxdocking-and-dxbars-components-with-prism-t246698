Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.ComponentModel.Composition
Imports DevExpress.Xpf.NavBar
Imports Microsoft.Practices.Prism.Regions

Namespace NavBarAndPrism
	<Export, PartCreationPolicy(CreationPolicy.NonShared)>
	Public Class NavBarControlAdapter
		Inherits RegionAdapterBase(Of NavBarControl)

		<ImportingConstructor>
		Public Sub New(ByVal behaviorFactory As IRegionBehaviorFactory)
			MyBase.New(behaviorFactory)
		End Sub
		Protected Overrides Sub Adapt(ByVal region As IRegion, ByVal regionTarget As NavBarControl)
			regionTarget.ItemsSource = region.Views
		End Sub
		Protected Overrides Function CreateRegion() As IRegion
			Return New Region()
		End Function
	End Class
End Namespace
