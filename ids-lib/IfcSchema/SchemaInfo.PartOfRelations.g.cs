// <auto-generated/>
// This code was automatically generated with information from Xbim.Essentials 5.9.0.408.
// Any changes made to this file will be lost.

using System;
using System.Collections.Generic;

namespace IdsLib.IfcSchema
{
    public partial class SchemaInfo
    {
        /// <summary>
        /// The names of classes across all schemas.
        /// </summary>
        public static IEnumerable<IfcOneToManyRelationInformation> AllPartOfRelations
        {
            get
            {
               yield return new IfcOneToManyRelationInformation("IfcRelAggregates", new[] { "Ifc2x3", "Ifc4", "Ifc4x3" }, "IfcObjectDefinition", "IfcObjectDefinition");
               yield return new IfcOneToManyRelationInformation("IfcRelAssignsToGroup", new[] { "Ifc2x3", "Ifc4", "Ifc4x3" }, "IfcGroup", "IfcObjectDefinition");
               yield return new IfcOneToManyRelationInformation("IfcRelContainedInSpatialStructure", new[] { "Ifc2x3", "Ifc4", "Ifc4x3" }, "IfcSpatialStructureElement", "IfcProduct");
               yield return new IfcOneToManyRelationInformation("IfcRelNests", new[] { "Ifc2x3", "Ifc4", "Ifc4x3" }, "IfcObjectDefinition", "IfcObjectDefinition");
            }
        }
    }
}

