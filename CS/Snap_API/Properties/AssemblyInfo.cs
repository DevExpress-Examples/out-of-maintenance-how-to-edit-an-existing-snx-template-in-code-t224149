// Developer Express Code Central Example:
// How to generate a document layout in code via the Snap application programming interface (API)
// 
// This example illustrates the Snap API
// (https://documentation.devexpress.com/#WindowsForms/CustomDocument14525) that is
// used to generate a document from scratch and connect it to data completely in
// code.
// The following code generates a tabular report layout. For a sample code
// that creates a mail-merge report (in the context of SnapDocumentServer
// (https://documentation.devexpress.com/#DocumentServer/clsDevExpressSnapSnapDocumentServertopic)),
// refer to the following example: How to automatically create mail-merge documents
// using the Snap Document Server
// (https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5078).
// SnapControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapSnapControltopic)
// extends the RichEditControl
// (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraRichEditRichEditControltopic)'s
// API and introduces the SnapList
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapListtopic)
// class that is used to insert dynamic data elements into a document.
// To generate
// a data-aware Snap document, do the following:
// - Create a Snap application and
// connect it to a data source
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument16043).
// - Add
// a SnapList to the SnapDocument
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapDocumenttopic).
// -
// To generate the SnapList layout, define the ListHeader, ListFooter, and
// RowTemplate
// (http://documentation.devexpress.com/#WindowsForms/DevExpressSnapCoreAPISnapList_RowTemplatetopic).
// - Inject data fields
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15559) into the
// document (e.g., by using SnapText to display text data).
// - Format the document
// content (see the FormatList method implementation in the Form1.cs file of the
// sample solution).
// - If required, apply grouping, sorting, and/or filtering to
// the SnapList content.
// A SnapEntity
// (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapEntitytopic)
// is open to customization only after calling its BeginUpdate method and not after
// the EndUpdate method is called to apply the new settings (see the GenerateLayout
// method in the Form1.cs file of the sample solution).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4781

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WindowsFormsApplication1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("WindowsFormsApplication1")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c922265b-239b-4855-9a6d-849a41c15348")]

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
[assembly: AssemblyFileVersion("1.0.0.0")]
