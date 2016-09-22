//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.31.0.
namespace IS24RestApi.User
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Ergebnisliste mit allen passenden Benutzern.</para>
    /// <para xml:lang="en">Resultlist with all matching users.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.31.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Users", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("users", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
    public partial class Users
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<User> _user;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("user", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public System.Collections.ObjectModel.Collection<User> User
        {
            get
            {
                return this._user;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Users" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Users" /> class.</para>
        /// </summary>
        public Users()
        {
            this._user = new System.Collections.ObjectModel.Collection<User>();
        }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Ein Benutzer im Accounting Kontext.</para>
    /// <para xml:lang="en">A user in the accounting context.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.31.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("User", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("user", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
    public partial class User
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">invalid characters w.r.t. XML will be filtered out on outgoing responses</para>
        /// <para xml:lang="en">in Bezug auf XML ungültige Zeichen werden bei der Ausgabe ausgefiltert</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("userName", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public string UserName { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("userContactDetails", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public IS24RestApi.Common.MasterDataContactDetailsType UserContactDetails { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Hierarchical Object Identifier intended to provide a cross-system uniqueness
        ///                in the format [DomainID].[LocalID].
        ///            </para>
        /// <para xml:lang="en">Pattern: [0-9]{3}\..{1,59}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{3}\\..{1,59}")]
        [System.Xml.Serialization.XmlElementAttribute("companyWideId", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public string CompanyWideId { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("userState", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public UserStateType UserStateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die UserState-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the UserState property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool UserStateValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<UserStateType> UserState
        {
            get
            {
                if (this.UserStateValueSpecified)
                {
                    return this.UserStateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.UserStateValue = value.GetValueOrDefault();
                this.UserStateValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ssoid", Namespace="http://rest.immobilienscout24.de/schema/user/1.0", DataType="long")]
        public long SsoidValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Ssoid-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Ssoid property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SsoidValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<long> Ssoid
        {
            get
            {
                if (this.SsoidValueSpecified)
                {
                    return this.SsoidValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SsoidValue = value.GetValueOrDefault();
                this.SsoidValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">invalid characters w.r.t. XML will be filtered out on outgoing responses</para>
        /// <para xml:lang="en">in Bezug auf XML ungültige Zeichen werden bei der Ausgabe ausgefiltert</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("customerNumber", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public string CustomerNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Hierarchical Object Identifier intended to provide a cross-system uniqueness
        ///                in the format [DomainID].[LocalID].
        ///            </para>
        /// <para xml:lang="en">Pattern: [0-9]{3}\..{1,59}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{3}\\..{1,59}")]
        [System.Xml.Serialization.XmlElementAttribute("customerCompanyWideId", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
        public string CustomerCompanyWideId { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("internalTest", Namespace="http://rest.immobilienscout24.de/schema/user/1.0", DataType="boolean")]
        public bool InternalTestValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InternalTest-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InternalTest property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool InternalTestValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> InternalTest
        {
            get
            {
                if (this.InternalTestValueSpecified)
                {
                    return this.InternalTestValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InternalTestValue = value.GetValueOrDefault();
                this.InternalTestValueSpecified = value.HasValue;
            }
        }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Zustände, die ein Benutzer haben kann.</para>
    /// <para xml:lang="en">States a user account can have.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.31.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UserStateType", Namespace="http://rest.immobilienscout24.de/schema/user/1.0")]
    public enum UserStateType
    {
        
        /// <summary>
        /// </summary>
        ACTIVE,
        
        /// <summary>
        /// </summary>
        INACTIVE,
        
        /// <summary>
        /// </summary>
        DELETED,
        
        /// <summary>
        /// </summary>
        UNKNOWN,
    }
}
