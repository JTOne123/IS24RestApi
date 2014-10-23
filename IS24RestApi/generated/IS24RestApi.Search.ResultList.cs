//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.3.5235.30570.
namespace IS24RestApi.Search.ResultList
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("resultlist", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0", AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("resultlist", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class Resultlist
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("paging", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IS24RestApi.Common.Paging Paging { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("searchId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string SearchId { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("matchCountList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("matchCount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<IS24RestApi.Common.MatchCount> MatchCountList { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MatchCountList-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MatchCountList collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatchCountListSpecified
        {
            get
            {
                return (this.MatchCountList.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Resultlist" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Resultlist" /> class.</para>
        /// </summary>
        public Resultlist()
        {
            this.MatchCountList = new Collection<IS24RestApi.Common.MatchCount>();
            this.ResultlistEntries = new Collection<ResultlistEntries>();
            this.Description = new System.Collections.ObjectModel.Collection<string>();
            this.Recommendations = new Collection<ResultlistRecommendation>();
            this.Advertisement = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("resultlistEntries", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistEntries> ResultlistEntries { get; private set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("text", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public System.Collections.ObjectModel.Collection<string> Description { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return (this.Description.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("recommendations", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("recommendation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistRecommendation> Recommendations { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Recommendations-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Recommendations collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendationsSpecified
        {
            get
            {
                return (this.Recommendations.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("advertisement", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("keyValues", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public System.Collections.ObjectModel.Collection<string> Advertisement { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Advertisement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Advertisement collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdvertisementSpecified
        {
            get
            {
                return (this.Advertisement.Count != 0);
            }
        }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Liste aller Einträge der Ergebnisliste (Hinweis: enthält auch oft
    ///        genutzte Informationen).</para>
    /// <para xml:lang="en">List of all entries of the resultlist (Note: includes also often used
    ///        data).</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistEntries", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistEntries
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("resultlistEntry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistEntry> ResultlistEntry { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ResultlistEntry-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ResultlistEntry collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultlistEntrySpecified
        {
            get
            {
                return (this.ResultlistEntry.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResultlistEntries" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultlistEntries" /> class.</para>
        /// </summary>
        public ResultlistEntries()
        {
            this.ResultlistEntry = new Collection<ResultlistEntry>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _numberOfHits = 0;
        
        /// <summary>
        /// <para xml:lang="de-DE">Anzahl der Suchergebnisse.</para>
        /// <para xml:lang="en">Number of the hits.</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("numberOfHits", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int NumberOfHits
        {
            get
            {
                return this._numberOfHits;
            }
            set
            {
                this._numberOfHits = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Immobilientyp der Einträge der Ergebnisliste.</para>
        /// <para xml:lang="en">RealEstateType of the result entries.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("realEstateType", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int RealEstateType { get; set; }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Ein Eintrag der Ergebnisliste.</para>
    /// <para xml:lang="en">An entry of the resultlist.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistEntry", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("resultlistEntry", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistEntry
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Liste von gruppierten Ergebnissen zum aktuellen Objekt.</para>
        /// <para xml:lang="en">A list of similar entries of the current result list entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("similarObjects", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("similarObject", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistEntry> SimilarObjects { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResultlistEntry" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultlistEntry" /> class.</para>
        /// </summary>
        public ResultlistEntry()
        {
            this.SimilarObjects = new Collection<ResultlistEntry>();
            this.Attributes = new Collection<ResultListEntryAttribute>();
            this.RealEstateTags = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Die Id der Immobilie.</para>
        /// <para xml:lang="en">The id of the real estate.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("realEstateId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="long")]
        public long RealEstateId { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Entfernung vom Zentrum der Umgebungssuche.</para>
        /// <para xml:lang="en">The distance from center of proximity search.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("distance", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="double")]
        public double Distance { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Fahrzeit vom Zentrum der Suche.</para>
        /// <para xml:lang="en">The travel time from the center of search.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("travelTime", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int TravelTime { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Die Immobilie der Ergebnisliste.</para>
        /// <para xml:lang="en">The real estate of the result list entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("realEstate", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
        public IS24RestApi.Search.Common.RealEstateForList RealEstate { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("publishedAfterRequestedDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="boolean")]
        public bool PublishedAfterRequestedDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PublishedAfterRequestedDate-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PublishedAfterRequestedDate property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PublishedAfterRequestedDateValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> PublishedAfterRequestedDate
        {
            get
            {
                if (this.PublishedAfterRequestedDateValueSpecified)
                {
                    return this.PublishedAfterRequestedDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PublishedAfterRequestedDateValue = value.GetValueOrDefault();
                this.PublishedAfterRequestedDateValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("attributes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("attribute", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultListEntryAttribute> Attributes { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Attributes-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Attributes collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttributesSpecified
        {
            get
            {
                return (this.Attributes.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("realEstateTags", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("tag", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public System.Collections.ObjectModel.Collection<string> RealEstateTags { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RealEstateTags-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RealEstateTags collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RealEstateTagsSpecified
        {
            get
            {
                return (this.RealEstateTags.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Link zum Element.</para>
        /// <para xml:lang="en">Link to the entity entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("href", Namespace="http://www.w3.org/1999/xlink", DataType="anyURI")]
        public string Href { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Elements.</para>
        /// <para xml:lang="en">Id of entity entry.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("id", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="long")]
        public long IdValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Id-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Id property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IdValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Elements.</para>
        /// <para xml:lang="en">Id of entity entry.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<long> Id
        {
            get
            {
                if (this.IdValueSpecified)
                {
                    return this.IdValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IdValue = value.GetValueOrDefault();
                this.IdValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Lesbarer Name des Elements (wenn vorhanden).</para>
        /// <para xml:lang="en">Human readable name of the entity (if it exists).</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("label", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Label { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der letzten Veränderung der Entität.</para>
        /// <para xml:lang="en">Date of the last modification of this entity.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("modification", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime ModificationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Modification-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Modification property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ModificationValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der letzten Veränderung der Entität.</para>
        /// <para xml:lang="en">Date of the last modification of this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> Modification
        {
            get
            {
                if (this.ModificationValueSpecified)
                {
                    return this.ModificationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ModificationValue = value.GetValueOrDefault();
                this.ModificationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der letzten Veränderung der Entität.</para>
        /// <para xml:lang="en">Creationdate of this entity.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("creation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime CreationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Creation-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Creation property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CreationValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der letzten Veränderung der Entität.</para>
        /// <para xml:lang="en">Creationdate of this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> Creation
        {
            get
            {
                if (this.CreationValueSpecified)
                {
                    return this.CreationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CreationValue = value.GetValueOrDefault();
                this.CreationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der ersten Einstellung der Entität.</para>
        /// <para xml:lang="en">PublishDate date of this entity.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("publishDate", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime PublishDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PublishDate-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PublishDate property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PublishDateValueSpecified { get; set; }
        
        /// <summary>
        /// <para xml:lang="de-DE">Datum der ersten Einstellung der Entität.</para>
        /// <para xml:lang="en">PublishDate date of this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> PublishDate
        {
            get
            {
                if (this.PublishDateValueSpecified)
                {
                    return this.PublishDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PublishDateValue = value.GetValueOrDefault();
                this.PublishDateValueSpecified = value.HasValue;
            }
        }
    }
    
    /// <summary>
    /// <para xml:lang="de-DE">Liste aller gruppierten
    ///				Einträge zum Treffer.</para>
    /// <para xml:lang="en">
    ///				List of all similar entries of the result entry. 
    ///      </para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("SimilarObjects", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class SimilarObjects
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("similarObject", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistEntry> SimilarObject { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SimilarObject-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SimilarObject collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SimilarObjectSpecified
        {
            get
            {
                return (this.SimilarObject.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SimilarObjects" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SimilarObjects" /> class.</para>
        /// </summary>
        public SimilarObjects()
        {
            this.SimilarObject = new Collection<ResultlistEntry>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultListEntryAttributes", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultListEntryAttributes
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("attribute", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultListEntryAttribute> Attribute { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Attribute-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Attribute collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttributeSpecified
        {
            get
            {
                return (this.Attribute.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResultListEntryAttributes" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultListEntryAttributes" /> class.</para>
        /// </summary>
        public ResultListEntryAttributes()
        {
            this.Attribute = new Collection<ResultListEntryAttribute>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultListEntryAttribute", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultListEntryAttribute
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("label", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Label { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("value", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("RealEstateTags", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class RealEstateTags
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("tag", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public System.Collections.ObjectModel.Collection<string> Tag { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Tag-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Tag collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TagSpecified
        {
            get
            {
                return (this.Tag.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RealEstateTags" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RealEstateTags" /> class.</para>
        /// </summary>
        public RealEstateTags()
        {
            this.Tag = new System.Collections.ObjectModel.Collection<string>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistDescription", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistDescription
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("text", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Text { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistRecommendations", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistRecommendations
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("recommendation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Collection<ResultlistRecommendation> Recommendation { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Recommendation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Recommendation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendationSpecified
        {
            get
            {
                return (this.Recommendation.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResultlistRecommendations" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResultlistRecommendations" /> class.</para>
        /// </summary>
        public ResultlistRecommendations()
        {
            this.Recommendation = new Collection<ResultlistRecommendation>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistRecommendation", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistRecommendation
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("title", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Title { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("sampleResultlistEntry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResultlistEntry SampleResultlistEntry { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResultlistRecommendationType TypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Type-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Type property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TypeValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<ResultlistRecommendationType> Type
        {
            get
            {
                if (this.TypeValueSpecified)
                {
                    return this.TypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TypeValue = value.GetValueOrDefault();
                this.TypeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("numberOfHits", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="int")]
        public int NumberOfHitsValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NumberOfHits-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NumberOfHits property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool NumberOfHitsValueSpecified { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<int> NumberOfHits
        {
            get
            {
                if (this.NumberOfHitsValueSpecified)
                {
                    return this.NumberOfHitsValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberOfHitsValue = value.GetValueOrDefault();
                this.NumberOfHitsValueSpecified = value.HasValue;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistRecommendationType", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public enum ResultlistRecommendationType
    {
        
        /// <summary>
        /// </summary>
        COURTAGE,
        
        /// <summary>
        /// </summary>
        GEO,
        
        /// <summary>
        /// </summary>
        PRICE,
        
        /// <summary>
        /// </summary>
        ROOM,
        
        /// <summary>
        /// </summary>
        AREA,
        
        /// <summary>
        /// </summary>
        POTENTIAL_HOMES,
        
        /// <summary>
        /// </summary>
        PLANNED_HOMES,
        
        /// <summary>
        /// </summary>
        JOINED_RECOMMENDATION,
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5235.30570")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ResultlistAdvertisement", Namespace="http://rest.immobilienscout24.de/schema/search/resultlist/1.0")]
    public partial class ResultlistAdvertisement
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("keyValues", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string KeyValues { get; set; }
    }
}
