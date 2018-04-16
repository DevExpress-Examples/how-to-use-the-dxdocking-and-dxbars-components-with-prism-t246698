# How to use the DXDocking and DXBars components with Prism


<p>This sample demonstrates how to use the DXDocking and DXBars components with Prism.</p>
<p><br /> The solution contains projects for the Silverlight platform:</p>
<p>1.The Infrastructure module contains common resources and the base IDocumentManager interface;</p>
<p>2. The Shell module - the main application module that contains the main form and module registration logic;</p>
<p>3. Four sub-modules - These will be injected into the main form via Prism.</p>
<p><br /> The Shell module contains the basic control layout for the application:</p>
<p>1. The BarManger component contains a main menu with application actions;</p>
<p>2. DockLayoutManager contains regions for sub-modules.</p>
<p>The Shell module implements the IDocumentManager interface and exports this interface via the Prism Export Attribute. This interface provides basic interaction functionality between the main module and sub-modules.</p>
<p><br /> Each sub-module implements a specific part of GUI (such as Grid, Text Editor, etc.) and contains a number of relative commands for this sub-module. The modules interact with the Shell module via the IDocumentManager interface, which is imported via the Prism Import attribute.</p>
<p><br /> Sub-modules can be separately customized in the Visual Studio designer.</p>
<p><br /> Note that when working with Prism, the bars merging feature is automatically supported: an MDI child and main menus are automatically merged when an MDI child form is activated or maximized. The DockLayoutManager.Merge event allows you to implement additional bars merging logic.<br /><br />To learn more on how to implement similar functionality in WPF, refer to the <a href="https://www.devexpress.com/Support/Center/p/E3340">E3340</a> example.<br /><br /></p>

<br/>


