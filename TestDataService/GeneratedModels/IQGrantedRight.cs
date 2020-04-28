using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQGrantedRight")]
	public class IQGrantedRight : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IQDateTimeFrom")]
		public DateTime IQDateTimeFrom { get; set; }
		[CProperty(ColumnPath ="IQDateTimeTo")]
		public DateTime IQDateTimeTo { get; set; }
		[CProperty(ColumnPath ="IQGranteeSysAdminUnitId")]
		public Guid IQGranteeSysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="IQGrantorSysAdminUnitId")]
		public Guid IQGrantorSysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="IQProcessed")]
		public bool IQProcessed { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:IQGrantorSysAdminUnitId")]
		public VwSysAdminUnit IQGrantorSysAdminUnit { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:IQGranteeSysAdminUnitId")]
		public VwSysAdminUnit IQGranteeSysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
