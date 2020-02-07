using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysSetting")]
	public class VwSysSetting : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCacheable")]
		public bool IsCacheable { get; set; }
		[CProperty(ColumnPath ="IsPersonal")]
		public bool IsPersonal { get; set; }
		[CProperty(ColumnPath ="IsSSPAvailable")]
		public bool IsSSPAvailable { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaUId")]
		public Guid ReferenceSchemaUId { get; set; }
		[CProperty(ColumnPath ="ValueTypeName")]
		public string ValueTypeName { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
