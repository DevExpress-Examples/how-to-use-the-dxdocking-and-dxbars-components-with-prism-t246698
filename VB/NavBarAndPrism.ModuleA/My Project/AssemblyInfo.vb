Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("NavBarAndPrism.ModuleA")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("DevExpress")>
<Assembly: AssemblyProduct("NavBarAndPrism")>
<Assembly: AssemblyCopyright("Copyright © DevExpress 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("c9bf2320-6509-40f9-b006-229e225dfae0")>

#If Not SILVERLIGHT Then
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly), assembly: AssemblyVersion("1.0.0.0"), assembly: AssemblyFileVersion("1.0.0.0")> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
	'(used if a resource is not found in the page, 
	' or application resource dictionaries)
	'(used if a resource is not found in the page, 
	' app, or any theme specific resource dictionaries)
#Else
<Assembly: AssemblyVersion("1.0.0.0"), assembly: AssemblyFileVersion("1.0.0.0")>
#End If

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
