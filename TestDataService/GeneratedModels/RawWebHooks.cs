using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RawWebHooks")]
	public class RawWebHooks : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Failed")]
		public bool Failed { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JsonData")]
		public byte[] JsonData { get; set; }
		[CProperty(ColumnPath ="Type")]
		public int Type { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
