﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxiomCoders.PdfReports {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AxiomCoders.PdfReports.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Failed Attaching Template File for usage.
        /// </summary>
        internal static string FailedAttachingTemplateFromFile {
            get {
                return ResourceManager.GetString("FailedAttachingTemplateFromFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed Attaching Template data for usage.
        /// </summary>
        internal static string FailedAttachingTemplateFromMemory {
            get {
                return ResourceManager.GetString("FailedAttachingTemplateFromMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed Generating PDF.
        /// </summary>
        internal static string FailedGeneratingPdf {
            get {
                return ResourceManager.GetString("FailedGeneratingPdf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialization of Component Failed.
        /// </summary>
        internal static string FailedGeneratorInitializing {
            get {
                return ResourceManager.GetString("FailedGeneratorInitializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shutdown of Generator Failed.
        /// </summary>
        internal static string FailedGeneratorShutdown {
            get {
                return ResourceManager.GetString("FailedGeneratorShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid serial number used. Check your serial number or use PdfReports in trial version instead.
        /// </summary>
        internal static string InvalidSerialNumber {
            get {
                return ResourceManager.GetString("InvalidSerialNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template File is not Specified.
        /// </summary>
        internal static string TemplateFileMissing {
            get {
                return ResourceManager.GetString("TemplateFileMissing", resourceCulture);
            }
        }
    }
}