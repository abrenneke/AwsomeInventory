﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPGIResource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RPG_Inventory_Remake_Common.Resources.ErrorMessage", typeof(ErrorMessage).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is null: {0}.
        /// </summary>
        public static string ArgumentIsNull {
            get {
                return ResourceManager.GetString("ArgumentIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both arguments are not null: {0} and {1}.
        /// </summary>
        public static string BothArgumentsAreNotNull {
            get {
                return ResourceManager.GetString("BothArgumentsAreNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both arguments are null: {0} and {1}.
        /// </summary>
        public static string BothArgumentsAreNull {
            get {
                return ResourceManager.GetString("BothArgumentsAreNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, Expected : {1}, Actual: {2}.
        /// </summary>
        public static string ExpectedString {
            get {
                return ResourceManager.GetString("ExpectedString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inventory tracker and Loadout is out of sync.
        /// </summary>
        public static string InvTrackerAndLoadoutOutOfSync {
            get {
                return ResourceManager.GetString("InvTrackerAndLoadoutOutOfSync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Margin is not match in compRPGILoadout.
        /// </summary>
        public static string MarginNotMatchIncompRPGILoadout {
            get {
                return ResourceManager.GetString("MarginNotMatchIncompRPGILoadout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At {0}, Variable: {1}, Value: {2}.
        /// </summary>
        public static string ReportString {
            get {
                return ResourceManager.GetString("ReportString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Corgi_TryToDeleteLastLoadout.
        /// </summary>
        public static string TryToDeleteLastLoadout {
            get {
                return ResourceManager.GetString("TryToDeleteLastLoadout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not match {1}.
        /// </summary>
        public static string ValueNotMatch {
            get {
                return ResourceManager.GetString("ValueNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong argument type: .
        /// </summary>
        public static string WrongArgumentType {
            get {
                return ResourceManager.GetString("WrongArgumentType", resourceCulture);
            }
        }
    }
}
