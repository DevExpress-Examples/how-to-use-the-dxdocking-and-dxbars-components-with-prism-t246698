using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.MefExtensions;
using System.ComponentModel.Composition.Hosting;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using NavBarAndPrism.Modules;
using DevExpress.Xpf.NavBar;

namespace NavBarAndPrism {
    public class Bootstrapper : MefBootstrapper {
        protected override void ConfigureAggregateCatalog() {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleA).Assembly));
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ModuleB).Assembly));
        }
        protected override void ConfigureModuleCatalog() {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuleA));
            moduleCatalog.AddModule(typeof(ModuleB));
        }
        protected override DependencyObject CreateShell() {
            return Container.GetExportedValue<Shell>();
        }
        protected override void InitializeShell() {
            base.InitializeShell();
            Application.Current.RootVisual = (Shell)this.Shell;
        }
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings() {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();
            mappings.RegisterMapping(typeof(NavBarControl), Container.GetExportedValue<NavBarControlAdapter>());
            return mappings;
        }
    }
}
