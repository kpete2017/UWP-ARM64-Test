﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace UWPLibrary.UWPLibrary_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::UWPLibrary.UWPLibrary_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::UWPLibrary.UWPLibrary_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::UWPLibrary.UWPLibrary_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        private global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider _Provider;
        private global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider Provider
        {
            get
            {
                if (_Provider == null)
                {
                    _Provider = new global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider();
                }
                return _Provider;
            }
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            return Provider.GetXamlType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            return Provider.GetXamlType(typeName);
        }
    }
}

