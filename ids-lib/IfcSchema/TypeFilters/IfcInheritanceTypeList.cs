﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IdsLib.IfcSchema.TypeFilters
{
    // todo: all IIfcTypeConstraint concrete classes need to covered thoroughly with unit tests

    [DebuggerDisplay("Types inheriting from {upperInvariantTopType} ({ConreteTypesCount})")]
    internal class IfcInheritanceTypeConstraint : IIfcTypeConstraint
	{
		private readonly string upperInvariantTopType;

		private readonly IfcSchemaVersions requiredSchemaVersions;

		private IEnumerable<string>? concreteTypes = null;

		internal int ConreteTypesCount => ConcreteTypes.Count();

        public IfcInheritanceTypeConstraint(string topType, IfcSchemaVersions requiredSchemaVersions)
		{
			this.upperInvariantTopType = topType.ToUpperInvariant();
			this.requiredSchemaVersions = requiredSchemaVersions;
		}

		public IEnumerable<string> ConcreteTypes
		{
			get
			{
				if (concreteTypes is null) 
				{
					// this gets to the name of the top class (it must exist in all required schemas)
				    IfcConcreteTypeList? c = null;
				
					var schemas = SchemaInfo.GetSchemas(requiredSchemaVersions);
					// we identify the intersection of classes in all required schemas

					foreach (var schema in schemas)
					{
						if (c == null)
							c = IfcConcreteTypeList.FromTopClass(schema, upperInvariantTopType);
						else
							c.Intersect(IfcConcreteTypeList.FromTopClass(schema, upperInvariantTopType));
						if (c.IsEmpty)
						{
							break;
						}
					}
				
					c ??= IfcConcreteTypeList.Empty;
                    concreteTypes = c.ConcreteTypes;
				}
				return concreteTypes;
			}
		}

		public bool IsEmpty => string.IsNullOrEmpty(upperInvariantTopType) || requiredSchemaVersions == IfcSchemaVersions.IfcNoVersion;

		public IIfcTypeConstraint Intersect(IIfcTypeConstraint? other)
		{
			if (other is null)
                return IfcConcreteTypeList.Empty;
            // todo: there's room form optimizing this method if the other is also of type IfcInheritanceTypeConstraint
            if (this.IsEmpty || other.IsEmpty)
				return IfcConcreteTypeList.Empty;
			return new IfcConcreteTypeList(
				this.ConcreteTypes.Intersect(other.ConcreteTypes)
				);
		}
	}


}
