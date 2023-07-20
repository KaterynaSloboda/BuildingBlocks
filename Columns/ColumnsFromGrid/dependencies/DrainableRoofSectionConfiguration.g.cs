//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>The configuration of drainable roof section</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DrainableRoofSectionConfiguration 
    {
        [JsonConstructor]
        public DrainableRoofSectionConfiguration(double @drainConnectionOffsetX, double @drainConnectionRunY, double @roofToCollectionDistanceZ)
        {
            this.DrainConnectionOffsetX = @drainConnectionOffsetX;
            this.DrainConnectionRunY = @drainConnectionRunY;
            this.RoofToCollectionDistanceZ = @roofToCollectionDistanceZ;
            }
        
        // Empty constructor
        public DrainableRoofSectionConfiguration()
        {
        }
    
        [JsonProperty("Drain Connection Offset (X)", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DrainConnectionOffsetX { get; set; } = 1D;
    
        [JsonProperty("Drain Connection Run (Y)", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DrainConnectionRunY { get; set; } = 1D;
    
        [JsonProperty("Roof to Collection Distance (Z)", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RoofToCollectionDistanceZ { get; set; } = 1D;
    
    
    }
}