﻿using System;

namespace LinqToDB.Mapping
{
	using SqlQuery;

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
	public class LocalTempTableAttribute : TableTempTypeAttribute
	{
		public LocalTempTableAttribute() : base(SqlTableTempType.LocalTemp)
		{
		}
	}
}