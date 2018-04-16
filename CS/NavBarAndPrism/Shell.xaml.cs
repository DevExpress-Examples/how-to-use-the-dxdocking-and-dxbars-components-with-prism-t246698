using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using DevExpress.Xpf.NavBar;

namespace NavBarAndPrism {
    [Export]
    public partial class Shell : UserControl {
        public Shell() {
            InitializeComponent();
        }
    }
}
