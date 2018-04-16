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
Imports Microsoft.Practices.Prism.MefExtensions
Imports System.ComponentModel.Composition.Hosting
Imports Microsoft.Practices.Prism.Modularity
Imports Microsoft.Practices.Prism.Regions
Imports NavBarAndPrism.Modules
Imports DevExpress.Xpf.NavBar

Namespace NavBarAndPrism
	Public Class Bootstrapper
		Inherits MefBootstrapper

		Protected Overrides Sub ConfigureAggregateCatalog()
			MyBase.ConfigureAggregateCatalog()
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(Bootstrapper).Assembly))
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(ModuleA).Assembly))
			AggregateCatalog.Catalogs.Add(New AssemblyCatalog(GetType(ModuleB).Assembly))
		End Sub
		Protected Overrides Sub ConfigureModuleCatalog()
			MyBase.ConfigureModuleCatalog()
			Dim moduleCatalog As ModuleCatalog = CType(Me.ModuleCatalog, ModuleCatalog)
			moduleCatalog.AddModule(GetType(ModuleA))
			moduleCatalog.AddModule(GetType(ModuleB))
		End Sub
		Protected Overrides Function CreateShell() As DependencyObject
			Return Container.GetExportedValue(Of Shell)()
		End Function
		Protected Overrides Sub InitializeShell()
			MyBase.InitializeShell()
			Application.Current.RootVisual = CType(Me.Shell, Shell)
		End Sub
		Protected Overrides Function ConfigureRegionAdapterMappings() As RegionAdapterMappings
			Dim mappings As RegionAdapterMappings = MyBase.ConfigureRegionAdapterMappings()
			mappings.RegisterMapping(GetType(NavBarControl), Container.GetExportedValue(Of NavBarControlAdapter)())
			Return mappings
		End Function
	End Class
End Namespace
