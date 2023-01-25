// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace EnvelopeBySite
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public  class EnvelopeBySiteInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public EnvelopeBySiteInputs(double @buildingHeight, double @foundationDepth, double @siteSetback, bool @useSetbacks, double @setbackInterval, double @setbackDepth, double @minimumTierArea, Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<EnvelopeBySiteInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @buildingHeight, @foundationDepth, @siteSetback, @useSetbacks, @setbackInterval, @setbackDepth, @minimumTierArea, @overrides});
            }
        
            this.BuildingHeight = @buildingHeight;
            this.FoundationDepth = @foundationDepth;
            this.SiteSetback = @siteSetback;
            this.UseSetbacks = @useSetbacks;
            this.SetbackInterval = @setbackInterval;
            this.SetbackDepth = @setbackDepth;
            this.MinimumTierArea = @minimumTierArea;
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Overall height of the building from grade.</summary>
        [Newtonsoft.Json.JsonProperty("Building Height", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(5D, 100D)]
        public double BuildingHeight { get; set; } = 20D;
    
        /// <summary>Depth of the building envelope below grade.</summary>
        [Newtonsoft.Json.JsonProperty("Foundation Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(5D, 20D)]
        public double FoundationDepth { get; set; } = 10D;
    
        /// <summary>Distance from site boundary to building envelope.</summary>
        [Newtonsoft.Json.JsonProperty("Site Setback", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0D, 30D)]
        public double SiteSetback { get; set; } = 0D;
    
        /// <summary>Enable envelope setbacks at regular intervals.</summary>
        [Newtonsoft.Json.JsonProperty("Use Setbacks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool UseSetbacks { get; set; } = true;
    
        /// <summary>Vertical distance between envelope setbacks.</summary>
        [Newtonsoft.Json.JsonProperty("Setback Interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(10D, 30D)]
        public double SetbackInterval { get; set; } = 20D;
    
        /// <summary>Offset depth from previous setback.</summary>
        [Newtonsoft.Json.JsonProperty("Setback Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1D, 3D)]
        public double SetbackDepth { get; set; } = 1D;
    
        /// <summary>Minimum area allowed for a setback tier.</summary>
        [Newtonsoft.Json.JsonProperty("Minimum Tier Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(10D, 100D)]
        public double MinimumTierArea { get; set; } = 50D;
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(IList<EnvelopeFootprintOverride> @envelopeFootprint)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @envelopeFootprint});
            }
        
            this.EnvelopeFootprint = @envelopeFootprint ?? this.EnvelopeFootprint;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Envelope Footprint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<EnvelopeFootprintOverride> EnvelopeFootprint { get; set; } = new List<EnvelopeFootprintOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class EnvelopeFootprintOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public EnvelopeFootprintOverride(string @id, EnvelopeFootprintIdentity @identity, EnvelopeFootprintValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<EnvelopeFootprintOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EnvelopeFootprintIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EnvelopeFootprintValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class EnvelopeFootprintIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public EnvelopeFootprintIdentity(double @elevation, Vector3 @siteCentroid)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<EnvelopeFootprintIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @elevation, @siteCentroid});
            }
        
            this.Elevation = @elevation;
            this.SiteCentroid = @siteCentroid;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Elevation { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Site Centroid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 SiteCentroid { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    public partial class EnvelopeFootprintValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public EnvelopeFootprintValue(Polygon @perimeter)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<EnvelopeFootprintValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter});
            }
        
            this.Perimeter = @perimeter;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polygon Perimeter { get; set; }
    
    }
}