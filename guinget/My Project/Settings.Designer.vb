﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property HideUnfinishedControls() As Boolean
            Get
                Return CType(Me("HideUnfinishedControls"),Boolean)
            End Get
            Set
                Me("HideUnfinishedControls") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property InstallInteractively() As Boolean
            Get
                Return CType(Me("InstallInteractively"),Boolean)
            End Get
            Set
                Me("InstallInteractively") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property RerunSearchAfterCacheUpdate() As Boolean
            Get
                Return CType(Me("RerunSearchAfterCacheUpdate"),Boolean)
            End Get
            Set
                Me("RerunSearchAfterCacheUpdate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Use7zipForExtraction() As Boolean
            Get
                Return CType(Me("Use7zipForExtraction"),Boolean)
            End Get
            Set
                Me("Use7zipForExtraction") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("""C:\Program Files\7-Zip\7z.exe""")>  _
        Public Property PathTo7zip() As String
            Get
                Return CType(Me("PathTo7zip"),String)
            End Get
            Set
                Me("PathTo7zip") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UseRobocopyForCopying() As Boolean
            Get
                Return CType(Me("UseRobocopyForCopying"),Boolean)
            End Get
            Set
                Me("UseRobocopyForCopying") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowSidebar() As Boolean
            Get
                Return CType(Me("ShowSidebar"),Boolean)
            End Get
            Set
                Me("ShowSidebar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property UpgradeSettingsFromPreviousVersion() As Boolean
            Get
                Return CType(Me("UpgradeSettingsFromPreviousVersion"),Boolean)
            End Get
            Set
                Me("UpgradeSettingsFromPreviousVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ExactMatchForLastSelectedIDSearch() As Boolean
            Get
                Return CType(Me("ExactMatchForLastSelectedIDSearch"),Boolean)
            End Get
            Set
                Me("ExactMatchForLastSelectedIDSearch") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DebuggingBypassCacheUpdate() As Boolean
            Get
                Return CType(Me("DebuggingBypassCacheUpdate"),Boolean)
            End Get
            Set
                Me("DebuggingBypassCacheUpdate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property OnlyDisplayLatestPackageVersion() As Boolean
            Get
                Return CType(Me("OnlyDisplayLatestPackageVersion"),Boolean)
            End Get
            Set
                Me("OnlyDisplayLatestPackageVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowLastSelectedPackageDetails() As Boolean
            Get
                Return CType(Me("ShowLastSelectedPackageDetails"),Boolean)
            End Get
            Set
                Me("ShowLastSelectedPackageDetails") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ElevateWinget() As Boolean
            Get
                Return CType(Me("ElevateWinget"),Boolean)
            End Get
            Set
                Me("ElevateWinget") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SearchWhenTyping() As Boolean
            Get
                Return CType(Me("SearchWhenTyping"),Boolean)
            End Get
            Set
                Me("SearchWhenTyping") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("325")>  _
        Public Property SearchWhenTypingTimerInterval() As Integer
            Get
                Return CType(Me("SearchWhenTypingTimerInterval"),Integer)
            End Get
            Set
                Me("SearchWhenTypingTimerInterval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property HiDPIMode() As Boolean
            Get
                Return CType(Me("HiDPIMode"),Boolean)
            End Get
            Set
                Me("HiDPIMode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("""winget""")>  _
        Public Property DefaultSourceName() As String
            Get
                Return CType(Me("DefaultSourceName"),String)
            End Get
            Set
                Me("DefaultSourceName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DeleteTempFilesAfterRefresh() As Boolean
            Get
                Return CType(Me("DeleteTempFilesAfterRefresh"),Boolean)
            End Get
            Set
                Me("DeleteTempFilesAfterRefresh") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("appsfeatures")>  _
        Public Property AppsListUI() As String
            Get
                Return CType(Me("AppsListUI"),String)
            End Get
            Set
                Me("AppsListUI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ReopenMiniOptionsWindowOnOpeningApplyChangesWindow() As Boolean
            Get
                Return CType(Me("ReopenMiniOptionsWindowOnOpeningApplyChangesWindow"),Boolean)
            End Get
            Set
                Me("ReopenMiniOptionsWindowOnOpeningApplyChangesWindow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SpecifyVersionOnInstall() As Boolean
            Get
                Return CType(Me("SpecifyVersionOnInstall"),Boolean)
            End Get
            Set
                Me("SpecifyVersionOnInstall") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SpecifyVersionOnUpgrade() As Boolean
            Get
                Return CType(Me("SpecifyVersionOnUpgrade"),Boolean)
            End Get
            Set
                Me("SpecifyVersionOnUpgrade") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SpecifyVersionOnUninstall() As Boolean
            Get
                Return CType(Me("SpecifyVersionOnUninstall"),Boolean)
            End Get
            Set
                Me("SpecifyVersionOnUninstall") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.guinget.My.MySettings
            Get
                Return Global.guinget.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
