﻿using System;

using MySql.Data.Types;

namespace LinqToDB.DataProvider
{
	using Mapping;

	public class MySqlMappingSchema : MappingSchema
	{
		public MySqlMappingSchema() : this(ProviderName.MySql)
		{
		}

		protected MySqlMappingSchema(string configuration) : base(configuration)
		{
			SetDataType(typeof(MySqlDecimal),  DataType.Decimal);
			SetDataType(typeof(MySqlDateTime), DataType.DateTime2);
		}
	}
}
