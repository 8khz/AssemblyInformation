﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.468
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssemblyInformation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AssemblyInformation.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzing assembly &apos;{0}&apos;.
        /// </summary>
        internal static string AnalyzingAssembly {
            get {
                return ResourceManager.GetString("AnalyzingAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finding binaries in &apos;{0}&apos;.
        /// </summary>
        internal static string AnalyzingFolder {
            get {
                return ResourceManager.GetString("AnalyzingFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly Information.
        /// </summary>
        internal static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not load 64bit assembly on 32bit operating system..
        /// </summary>
        internal static string BitnessMismatch {
            get {
                return ResourceManager.GetString("BitnessMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to list binaries..
        /// </summary>
        internal static string FailedToListBinaries {
            get {
                return ResourceManager.GetString("FailedToListBinaries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to locate file {0}.
        /// </summary>
        internal static string FailedToLocateFile {
            get {
                return ResourceManager.GetString("FailedToLocateFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load DLL.  Error: {0}.
        /// </summary>
        internal static string LoadError {
            get {
                return ResourceManager.GetString("LoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The assembly &apos;{0}&apos; is not a .Net assembly. Assembly Information supports only .Net assemblies/binaries..
        /// </summary>
        internal static string NotDotNetAssembly {
            get {
                return ResourceManager.GetString("NotDotNetAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The module was expected to contain an assembly manifest.
        /// </summary>
        internal static string NotDotNetAssemblyErrorMessage {
            get {
                return ResourceManager.GetString("NotDotNetAssemblyErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Assembly Information
        ///Displays information on a .NET Assembly.  Developed by Rotem Bloom &amp; Ashutosh Bhawasinka.
        ///
        ///Usage:
        ///AssemblyInformation.exe &lt;assembly&gt;.
        /// </summary>
        internal static string UsageString {
            get {
                return ResourceManager.GetString("UsageString", resourceCulture);
            }
        }
    }
}
