﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Domain.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Daily dose is already taken..
        /// </summary>
        internal static string DailyDoseAlreadyTakenException {
            get {
                return ResourceManager.GetString("DailyDoseAlreadyTakenException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dispenser already exists..
        /// </summary>
        internal static string DispenserAlreadyExistsException {
            get {
                return ResourceManager.GetString("DispenserAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dispenser was not found..
        /// </summary>
        internal static string DispenserNotFoundException {
            get {
                return ResourceManager.GetString("DispenserNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Medicine was not found..
        /// </summary>
        internal static string MedicineNotFoundException {
            get {
                return ResourceManager.GetString("MedicineNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Medicine already exists..
        /// </summary>
        internal static string MedicinesAlreadyExistsException {
            get {
                return ResourceManager.GetString("MedicinesAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Medicine is already registred in dispenser..
        /// </summary>
        internal static string MedicineStockAlreadyExistsException {
            get {
                return ResourceManager.GetString("MedicineStockAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Medicine is not registred in the dispenser..
        /// </summary>
        internal static string MedicineStockDoesNotExistException {
            get {
                return ResourceManager.GetString("MedicineStockDoesNotExistException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not enough medicine in the dispensor..
        /// </summary>
        internal static string NotEnoughMedicineException {
            get {
                return ResourceManager.GetString("NotEnoughMedicineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password does not match..
        /// </summary>
        internal static string PasswordNotMatchException {
            get {
                return ResourceManager.GetString("PasswordNotMatchException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prescription for current user already  exists..
        /// </summary>
        internal static string PrescriptionAlreadyExistsException {
            get {
                return ResourceManager.GetString("PrescriptionAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prescription has expired..
        /// </summary>
        internal static string PrescriptionHasExpiredException {
            get {
                return ResourceManager.GetString("PrescriptionHasExpiredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prescription was not found..
        /// </summary>
        internal static string PrescriptionNotFoundException {
            get {
                return ResourceManager.GetString("PrescriptionNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User already exists..
        /// </summary>
        internal static string UserAlreadyExistsException {
            get {
                return ResourceManager.GetString("UserAlreadyExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User was not found..
        /// </summary>
        internal static string UserNotFoundException {
            get {
                return ResourceManager.GetString("UserNotFoundException", resourceCulture);
            }
        }
    }
}
