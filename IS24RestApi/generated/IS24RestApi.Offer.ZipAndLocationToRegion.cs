//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.214.0.
namespace IS24RestApi.Offer.ZipAndLocationToRegion
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
    public enum PriceRegion
    {
        
        /// <summary>
        /// </summary>
        A,
        
        /// <summary>
        /// </summary>
        B,
        
        /// <summary>
        /// </summary>
        C,
        
        /// <summary>
        /// </summary>
        D,
        
        /// <summary>
        /// </summary>
        E,
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegionAssignment", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("priceRegionAssignment", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
    public partial class PriceRegionAssignment
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("region", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
        public PriceRegion Region { get; set; }
    }
}
