using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QandA")]
	public class QandA : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AlternativeHosts")]
		public string AlternativeHosts { get; set; }
		[CProperty(ColumnPath ="ChosenStartDateTime")]
		public DateTime ChosenStartDateTime { get; set; }
		[CProperty(ColumnPath ="ChosenTimeZoneId")]
		public Guid ChosenTimeZoneId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="GmtStartDateTime")]
		public DateTime GmtStartDateTime { get; set; }
		[CProperty(ColumnPath ="HostId")]
		public string HostId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JoinUrl")]
		public string JoinUrl { get; set; }
		[CProperty(ColumnPath ="LanguageId")]
		public Guid LanguageId { get; set; }
		[CProperty(ColumnPath ="MeetingId")]
		public string MeetingId { get; set; }
		[CProperty(ColumnPath ="MeetingUUID")]
		public string MeetingUUID { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationUrl")]
		public string RegistrationUrl { get; set; }
		[CProperty(ColumnPath ="StartUrl")]
		public string StartUrl { get; set; }
		[CProperty(ColumnPath ="TrainerId")]
		public Guid TrainerId { get; set; }
		[CProperty(ColumnPath ="ZoomTimeZoneId")]
		public Guid ZoomTimeZoneId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:TrainerId")]
		public Contact Trainer { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		[CProperty(Navigation ="ZoomTimeZone:ZoomTimeZoneId")]
		public ZoomTimeZone ZoomTimeZone { get; set; }
		[CProperty(Navigation ="ZoomTimeZone:ChosenTimeZoneId")]
		public ZoomTimeZone ChosenTimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="QandAFile:QandAId")]
		public virtual ICollection<QandAFile> QandAFileByQandA { get; set; }
		[CProperty(Association ="QandAInFolder:QandAId")]
		public virtual ICollection<QandAInFolder> QandAInFolderByQandA { get; set; }
		[CProperty(Association ="QandAInTag:EntityId")]
		public virtual ICollection<QandAInTag> QandAInTagByEntity { get; set; }
		#endregion
	}
}
