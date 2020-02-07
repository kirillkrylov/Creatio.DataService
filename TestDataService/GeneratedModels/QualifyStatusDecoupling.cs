using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QualifyStatusDecoupling")]
	public class QualifyStatusDecoupling : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvailableStatusId")]
		public Guid AvailableStatusId { get; set; }
		[CProperty(ColumnPath ="CurrentStatusId")]
		public Guid CurrentStatusId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="QualifyStatus:CurrentStatusId")]
		public QualifyStatus CurrentStatus { get; set; }
		[CProperty(Navigation ="QualifyStatus:AvailableStatusId")]
		public QualifyStatus AvailableStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
