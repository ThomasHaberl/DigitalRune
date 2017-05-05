// IMPORTANT: Do not change AssemblyInfo.cs. The file is generated automatically. 
// Apply any changes to AssemblyInfo.template instead.

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("DigitalRune.Windows.Framework")]
[assembly: AssemblyDescription("Windows application framework.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("DigitalRune")]
[assembly: AssemblyProduct("DigitalRune")]
[assembly: AssemblyCopyright("Copyright © 2008-2014 DigitalRune GmbH. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en")]

#if !SILVERLIGHT && !WINDOWS_PHONE
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

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.12871")]
[assembly: CLSCompliant(true)]

[assembly: InternalsVisibleTo("DigitalRune.Windows.Framework.Tests,PublicKey=002400000480000094000000060200000024000052534131000400000100010071ebe9d74d347649f6004634291017c1f804788931790d576daa52787fbd89cdb23d73f020c12bae70c9761b1eeacf48d742b96277585a69484ad148c77a5ce95fe1bd00d6032daf1178debda2ddf8c5acf44fd11df0151bd5051907062a2eff39f7421e0d9afdc90f97f1d87f4ac67df092e41472d1cdcba7d32afd06ff97af")]

// Define xmlns for use in XAML.
[assembly: XmlnsPrefix("http://schemas.digitalrune.com/windows", "dr")]
[assembly: XmlnsDefinition("http://schemas.digitalrune.com/windows", "DigitalRune.Windows.Framework")]
