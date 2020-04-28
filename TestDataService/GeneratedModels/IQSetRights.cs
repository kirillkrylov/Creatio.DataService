using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQSetRights")]
	public class IQSetRights : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IQGrantedTo")]
		public DateTime IQGrantedTo { get; set; }
		[CProperty(ColumnPath ="IQGrantFrom")]
		public DateTime IQGrantFrom { get; set; }
		[CProperty(ColumnPath ="IQName")]
		public string IQName { get; set; }
		[CProperty(ColumnPath ="IQObject")]
		public string IQObject { get; set; }
		[CProperty(ColumnPath ="IQProcessLogId")]
		public Guid IQProcessLogId { get; set; }
		[CProperty(ColumnPath ="IQRightPeriodId")]
		public Guid IQRightPeriodId { get; set; }
		[CProperty(ColumnPath ="IQStatusId")]
		public Guid IQStatusId { get; set; }
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
		[CProperty(Navigation ="IQActualStatus:IQStatusId")]
		public IQActualStatus IQStatus { get; set; }
		[CProperty(Navigation ="IQRightPeriod:IQRightPeriodId")]
		public IQRightPeriod IQRightPeriod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:IQIQSetRightsId")]
		public virtual ICollection<Activity> ActivityByIQIQSetRights { get; set; }
		[CProperty(Association ="IQAddRight:IQSetRightsId")]
		public virtual ICollection<IQAddRight> IQAddRightByIQSetRights { get; set; }
		[CProperty(Association ="IQLimitRight:IQSetRightsId")]
		public virtual ICollection<IQLimitRight> IQLimitRightByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsFile:IQSetRightsId")]
		public virtual ICollection<IQSetRightsFile> IQSetRightsFileByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsInFolder:IQSetRightsId")]
		public virtual ICollection<IQSetRightsInFolder> IQSetRightsInFolderByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsInTag:EntityId")]
		public virtual ICollection<IQSetRightsInTag> IQSetRightsInTagByEntity { get; set; }
		#endregion
	}
}
