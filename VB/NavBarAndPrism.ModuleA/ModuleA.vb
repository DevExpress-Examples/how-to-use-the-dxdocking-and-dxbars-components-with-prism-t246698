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
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Regions
Imports NavBarAndPrism.Views
Imports Microsoft.Practices.Prism.MefExtensions.Modularity
Imports System.ComponentModel.Composition

Namespace NavBarAndPrism.Modules
	<ModuleExport(GetType(ModuleA))>
	Public Class ModuleA
		Implements IModule

		<Import>
		Public RegionManager As IRegionManager
		Public Sub Initialize() Implements IModule.Initialize 
			RegionManager.RegisterViewWithRegion("NavBarControlRegion", GetType(ModuleAView))
		End Sub
	End Class
End Namespace
