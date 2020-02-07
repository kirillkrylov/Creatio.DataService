using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GuidedLearning")]
	public class GuidedLearning : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AlternativeHosts")]
		public string AlternativeHosts { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="EndDateTime")]
		public DateTime EndDateTime { get; set; }
		[CProperty(ColumnPath ="GoogleForm")]
		public string GoogleForm { get; set; }
		[CProperty(ColumnPath ="GuidedLearningStatusId")]
		public Guid GuidedLearningStatusId { get; set; }
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
		[CProperty(ColumnPath ="NodeId")]
		public int NodeId { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationUrl")]
		public string RegistrationUrl { get; set; }
		[CProperty(ColumnPath ="SharedFolder")]
		public string SharedFolder { get; set; }
		[CProperty(ColumnPath ="StartDateTime")]
		public DateTime StartDateTime { get; set; }
		[CProperty(ColumnPath ="StartUrl")]
		public string StartUrl { get; set; }
		[CProperty(ColumnPath ="TrainerId")]
		public Guid TrainerId { get; set; }
		[CProperty(ColumnPath ="TrainingTypeId")]
		public Guid TrainingTypeId { get; set; }
		[CProperty(ColumnPath ="ZoomTimeZoneId")]
		public Guid ZoomTimeZoneId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CertificationType:TrainingTypeId")]
		public CertificationType TrainingType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:TrainerId")]
		public Contact Trainer { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		[CProperty(Navigation ="UsrGLStatuses:GuidedLearningStatusId")]
		public UsrGLStatuses GuidedLearningStatus { get; set; }
		[CProperty(Navigation ="ZoomTimeZone:ZoomTimeZoneId")]
		public ZoomTimeZone ZoomTimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:GuidedLearningId")]
		public virtual ICollection<Activity> ActivityByGuidedLearning { get; set; }
		[CProperty(Association ="GuidedLearningFile:GuidedLearningId")]
		public virtual ICollection<GuidedLearningFile> GuidedLearningFileByGuidedLearning { get; set; }
		[CProperty(Association ="GuidedLearningInFolder:GuidedLearningId")]
		public virtual ICollection<GuidedLearningInFolder> GuidedLearningInFolderByGuidedLearning { get; set; }
		[CProperty(Association ="GuidedLearningInTag:EntityId")]
		public virtual ICollection<GuidedLearningInTag> GuidedLearningInTagByEntity { get; set; }
		[CProperty(Association ="GuidedLearningOccurances:GuidedLearningId")]
		public virtual ICollection<GuidedLearningOccurances> GuidedLearningOccurancesByGuidedLearning { get; set; }
		[CProperty(Association ="GuidedLearningParticipants:GuidedLearningId")]
		public virtual ICollection<GuidedLearningParticipants> GuidedLearningParticipantsByGuidedLearning { get; set; }
		#endregion
	}
}
