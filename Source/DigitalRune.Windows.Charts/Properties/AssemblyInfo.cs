// IMPORTANT: Do not change AssemblyInfo.cs. The file is generated automatically. 
// Apply any changes to AssemblyInfo.template instead.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Resources;
using System.Windows.Markup;

#if !SILVERLIGHT
using System.Windows;
#endif


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DigitalRune.Windows.Charts")]
[assembly: AssemblyDescription("Charts library for the Windows Presentation Foundation (WPF) and Silverlight.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("DigitalRune")]
[assembly: AssemblyProduct("DigitalRune")]
[assembly: AssemblyCopyright("Copyright © 2007-2014 DigitalRune GmbH. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]

#if !SILVERLIGHT
[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page, 
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page, 
                                              // app, or any theme specific resource dictionaries)
)]
#endif


// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.2.0.0")]
[assembly: AssemblyFileVersion("1.2.0.14551")]
[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguageAttribute("en")]

// Define xmlns for use in XAML.
[assembly: XmlnsPrefix("http://schemas.digitalrune.com/windows", "dr")]
[assembly: XmlnsDefinition("http://schemas.digitalrune.com/windows", "DigitalRune.Windows.Charts")]
[assembly: XmlnsDefinition("http://schemas.digitalrune.com/windows", "DigitalRune.Windows.Charts.Interactivity")]

// Make internals visible to unit tests.
[assembly: InternalsVisibleTo("DigitalRune.Windows.Charts.Tests,PublicKey=002400000480000094000000060200000024000052534131000400000100010071ebe9d74d347649f6004634291017c1f804788931790d576daa52787fbd89cdb23d73f020c12bae70c9761b1eeacf48d742b96277585a69484ad148c77a5ce95fe1bd00d6032daf1178debda2ddf8c5acf44fd11df0151bd5051907062a2eff39f7421e0d9afdc90f97f1d87f4ac67df092e41472d1cdcba7d32afd06ff97af")]
