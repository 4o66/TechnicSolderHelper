﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TechnicSolderHelper.Properties {
    
    
    [CompilerGenerated()]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("C:\\Users\\User\\AppData\\Roaming\\.minecraft\\mods")]
        [SettingsManageability(SettingsManageability.Roaming)]
        public string InputDirectory {
            get {
                return ((string)(this["InputDirectory"]));
            }
            set {
                this["InputDirectory"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("C:\\SolderHelper")]
        public string OutputDirectory {
            get {
                return ((string)(this["OutputDirectory"]));
            }
            set {
                this["OutputDirectory"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool FirstRun {
            get {
                return ((bool)(this["FirstRun"]));
            }
            set {
                this["FirstRun"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool ClearFolderBeforeBeginning {
            get {
                return ((bool)(this["ClearFolderBeforeBeginning"]));
            }
            set {
                this["ClearFolderBeforeBeginning"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool CreateTechnicSolderFiles {
            get {
                return ((bool)(this["CreateTechnicSolderFiles"]));
            }
            set {
                this["CreateTechnicSolderFiles"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool CreateTechnicConfigZip {
            get {
                return ((bool)(this["CreateTechnicConfigZip"]));
            }
            set {
                this["CreateTechnicConfigZip"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool CreateSolderPack {
            get {
                return ((bool)(this["CreateSolderPack"]));
            }
            set {
                this["CreateSolderPack"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool CreateFTBPack {
            get {
                return ((bool)(this["CreateFTBPack"]));
            }
            set {
                this["CreateFTBPack"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool CreatePrivateFTBPack {
            get {
                return ((bool)(this["CreatePrivateFTBPack"]));
            }
            set {
                this["CreatePrivateFTBPack"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool CheckTecnicPermissions {
            get {
                return ((bool)(this["CheckTecnicPermissions"]));
            }
            set {
                this["CheckTecnicPermissions"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("True")]
        public bool TechnicPrivatePermissionsLevel {
            get {
                return ((bool)(this["TechnicPrivatePermissionsLevel"]));
            }
            set {
                this["TechnicPrivatePermissionsLevel"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool UploadToFTPServer {
            get {
                return ((bool)(this["UploadToFTPServer"]));
            }
            set {
                this["UploadToFTPServer"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool IncludeForgeVersion {
            get {
                return ((bool)(this["IncludeForgeVersion"]));
            }
            set {
                this["IncludeForgeVersion"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string ftpPassword {
            get {
                return ((string)(this["ftpPassword"]));
            }
            set {
                this["ftpPassword"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string ftpUserName {
            get {
                return ((string)(this["ftpUserName"]));
            }
            set {
                this["ftpUserName"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string ftpUrl {
            get {
                return ((string)(this["ftpUrl"]));
            }
            set {
                this["ftpUrl"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool HasBeenWarnedAboutLongFTBTimes {
            get {
                return ((bool)(this["HasBeenWarnedAboutLongFTBTimes"]));
            }
            set {
                this["HasBeenWarnedAboutLongFTBTimes"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string mysqlPassword {
            get {
                return ((string)(this["mysqlPassword"]));
            }
            set {
                this["mysqlPassword"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string mysqlUsername {
            get {
                return ((string)(this["mysqlUsername"]));
            }
            set {
                this["mysqlUsername"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string mysqlDatabase {
            get {
                return ((string)(this["mysqlDatabase"]));
            }
            set {
                this["mysqlDatabase"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("")]
        public string mysqlAddress {
            get {
                return ((string)(this["mysqlAddress"]));
            }
            set {
                this["mysqlAddress"] = value;
            }
        }
        
        [UserScopedSetting()]
        [DebuggerNonUserCode()]
        [DefaultSettingValue("False")]
        public bool useSolder {
            get {
                return ((bool)(this["useSolder"]));
            }
            set {
                this["useSolder"] = value;
            }
        }
    }
}
