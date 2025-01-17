// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace FacadeGridByLevels
{
    public class FacadeGridByLevelsOutputs: SystemResults
    {
		/// <summary>
		/// The number of unique facade panels.
		/// </summary>
		[JsonProperty("Unique Panel Count")]
		public double UniquePanelCount {get; set;}

		/// <summary>
		/// The total number of facade panels.
		/// </summary>
		[JsonProperty("Total Panel Count")]
		public double TotalPanelCount {get; set;}



        /// <summary>
        /// Construct a FacadeGridByLevelsOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FacadeGridByLevelsOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a FacadeGridByLevelsOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FacadeGridByLevelsOutputs(double uniquePanelCount, double totalPanelCount): base()
        {
			this.UniquePanelCount = uniquePanelCount;
			this.TotalPanelCount = totalPanelCount;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}