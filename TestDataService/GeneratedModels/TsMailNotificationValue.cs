using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsMailNotificationValue")]
	public class TsMailNotificationValue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId { get; set; }
		[CProperty(ColumnPath ="EmailNotificationId")]
		public Guid EmailNotificationId { get; set; }
		[CProperty(ColumnPath ="EmailTemplateId")]
		public Guid EmailTemplateId { get; set; }
		[CProperty(ColumnPath ="From")]
		public string From { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
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
		[CProperty(Navigation ="EmailTemplate:EmailTemplateId")]
		public EmailTemplate EmailTemplate { get; set; }
		[CProperty(Navigation ="SysCulture:CultureId")]
		public SysCulture Culture { get; set; }
		[CProperty(Navigation ="TsEmailNotification:EmailNotificationId")]
		public TsEmailNotification EmailNotification { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
