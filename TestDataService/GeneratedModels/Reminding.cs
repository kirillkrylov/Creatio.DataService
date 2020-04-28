using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Reminding")]
	public class Reminding : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AnniversaryDate")]
		public DateTime AnniversaryDate { get; set; }
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId { get; set; }
		[CProperty(ColumnPath ="Config")]
		public string Config { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Hash")]
		public string Hash { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsNeedToSend")]
		public bool IsNeedToSend { get; set; }
		[CProperty(ColumnPath ="IsRead")]
		public bool IsRead { get; set; }
		[CProperty(ColumnPath ="LoaderId")]
		public Guid LoaderId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NotificationTypeId")]
		public Guid NotificationTypeId { get; set; }
		[CProperty(ColumnPath ="PopupTitle")]
		public string PopupTitle { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RemindTime")]
		public DateTime RemindTime { get; set; }
		[CProperty(ColumnPath ="SenderId")]
		public Guid SenderId { get; set; }
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId { get; set; }
		[CProperty(ColumnPath ="SubjectCaption")]
		public string SubjectCaption { get; set; }
		[CProperty(ColumnPath ="SubjectId")]
		public Guid SubjectId { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaId")]
		public Guid SysEntitySchemaId { get; set; }
		[CProperty(ColumnPath ="TypeCaption")]
		public string TypeCaption { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="NotificationType:NotificationTypeId")]
		public NotificationType NotificationType { get; set; }
		[CProperty(Navigation ="RemindingSource:SourceId")]
		public RemindingSource Source { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:SysEntitySchemaId")]
		public VwSysModuleEntity SysEntitySchema { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:LoaderId")]
		public VwSysModuleEntity Loader { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
