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
using System.ComponentModel.Composition;
using DevExpress.Xpf.NavBar;
using Microsoft.Practices.Prism.Regions;

namespace NavBarAndPrism {
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class NavBarControlAdapter : RegionAdapterBase<NavBarControl> {
        [ImportingConstructor]
        public NavBarControlAdapter(IRegionBehaviorFactory behaviorFactory)
            : base(behaviorFactory) {
        }
        protected override void Adapt(IRegion region, NavBarControl regionTarget) {
            regionTarget.ItemsSource = region.Views;
        }
        protected override IRegion CreateRegion() {
            return new Region();
        }
    }
}
