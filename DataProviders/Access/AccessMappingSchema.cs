﻿using System;

namespace LinqToDB.DataProvider
{
	using Mapping;

	public class AccessMappingSchema : MappingSchema
	{
		public AccessMappingSchema() : this(ProviderName.Access)
		{
		}

		protected AccessMappingSchema(string configuration) : base(configuration)
		{
			SetDataType(typeof(DateTime), DataType.DateTime);
		}
	}
}
