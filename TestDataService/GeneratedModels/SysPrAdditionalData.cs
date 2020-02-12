using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPrAdditionalData")]
	public class SysPrAdditionalData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Data")]
		public string Data { get; set; }
		[CProperty(ColumnPath ="DateTime")]
		public DateTime DateTime { get; set; }
		[CProperty(ColumnPath ="EntityRecordId")]
		public Guid EntityRecordId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="SysProcessUId")]
		public Guid SysProcessUId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
