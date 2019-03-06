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
namespace IS24RestApi.Offer.ProductBookingOverview
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>Booking with name, price and number of bookings</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProductBooking
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("name", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("numberOfBookings", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public long NumberOfBookings { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("price", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public decimal Price { get; set; }
    }
    
    /// <summary>
    /// <para>Overview of bookings which are necessary for the product recommondation</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.214.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    public partial class ProductBookingOverview
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ProductBooking> _productBooking;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public System.Collections.ObjectModel.Collection<ProductBooking> ProductBooking
        {
            get
            {
                return this._productBooking;
            }
            private set
            {
                this._productBooking = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ProductBooking-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ProductBooking collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductBookingSpecified
        {
            get
            {
                return (this.ProductBooking.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ProductBookingOverview" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ProductBookingOverview" /> class.</para>
        /// </summary>
        public ProductBookingOverview()
        {
            this._productBooking = new System.Collections.ObjectModel.Collection<ProductBooking>();
        }
    }
}
