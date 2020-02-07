using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Certification")]
	public class Certification : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AlternativeHosts")]
		public string AlternativeHosts { get; set; }
		[CProperty(ColumnPath ="AutoSend")]
		public bool AutoSend { get; set; }
		[CProperty(ColumnPath ="CertificateNumber")]
		public string CertificateNumber { get; set; }
		[CProperty(ColumnPath ="CertificationProductId")]
		public Guid CertificationProductId { get; set; }
		[CProperty(ColumnPath ="CertificationStatusId")]
		public Guid CertificationStatusId { get; set; }
		[CProperty(ColumnPath ="CertificationTypeId")]
		public Guid CertificationTypeId { get; set; }
		[CProperty(ColumnPath ="ChosenStartDateTime")]
		public DateTime ChosenStartDateTime { get; set; }
		[CProperty(ColumnPath ="ChosenTimeZoneId")]
		public Guid ChosenTimeZoneId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DrupalCertId")]
		public string DrupalCertId { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="GmtStartDateTime")]
		public DateTime GmtStartDateTime { get; set; }
		[CProperty(ColumnPath ="GoogleCalendarURL")]
		public string GoogleCalendarURL { get; set; }
		[CProperty(ColumnPath ="HostId")]
		public string HostId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InviteSent")]
		public bool InviteSent { get; set; }
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
		[CProperty(ColumnPath ="POMId")]
		public Guid POMId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationUrl")]
		public string RegistrationUrl { get; set; }
		[CProperty(ColumnPath ="ReminderSent")]
		public bool ReminderSent { get; set; }
		[CProperty(ColumnPath ="ResultScore")]
		public int ResultScore { get; set; }
		[CProperty(ColumnPath ="SchedulerActivityId")]
		public Guid SchedulerActivityId { get; set; }
		[CProperty(ColumnPath ="StartUrl")]
		public string StartUrl { get; set; }
		[CProperty(ColumnPath ="StudentId")]
		public Guid StudentId { get; set; }
		[CProperty(ColumnPath ="TrainerId")]
		public Guid TrainerId { get; set; }
		[CProperty(ColumnPath ="WorkCompetenceLevelId")]
		public Guid WorkCompetenceLevelId { get; set; }
		[CProperty(ColumnPath ="WorkIdCertificate")]
		public string WorkIdCertificate { get; set; }
		[CProperty(ColumnPath ="WorkIdEa")]
		public string WorkIdEa { get; set; }
		[CProperty(ColumnPath ="ZoomTimeZoneId")]
		public Guid ZoomTimeZoneId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:SchedulerActivityId")]
		public Activity SchedulerActivity { get; set; }
		[CProperty(Navigation ="CertificationProduct:CertificationProductId")]
		public CertificationProduct CertificationProduct { get; set; }
		[CProperty(Navigation ="CertificationStatus:CertificationStatusId")]
		public CertificationStatus CertificationStatus { get; set; }
		[CProperty(Navigation ="CertificationType:CertificationTypeId")]
		public CertificationType CertificationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:StudentId")]
		public Contact Student { get; set; }
		[CProperty(Navigation ="Contact:TrainerId")]
		public Contact Trainer { get; set; }
		[CProperty(Navigation ="Contact:POMId")]
		public Contact POM { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		[CProperty(Navigation ="WorkCompetenceLevel:WorkCompetenceLevelId")]
		public WorkCompetenceLevel WorkCompetenceLevel { get; set; }
		[CProperty(Navigation ="ZoomTimeZone:ZoomTimeZoneId")]
		public ZoomTimeZone ZoomTimeZone { get; set; }
		[CProperty(Navigation ="ZoomTimeZone:ChosenTimeZoneId")]
		public ZoomTimeZone ChosenTimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:CertificationId")]
		public virtual ICollection<Activity> ActivityByCertification { get; set; }
		[CProperty(Association ="CertificationFile:CertificationId")]
		public virtual ICollection<CertificationFile> CertificationFileByCertification { get; set; }
		[CProperty(Association ="CertificationInFolder:CertificationId")]
		public virtual ICollection<CertificationInFolder> CertificationInFolderByCertification { get; set; }
		[CProperty(Association ="CertificationInTag:EntityId")]
		public virtual ICollection<CertificationInTag> CertificationInTagByEntity { get; set; }
		[CProperty(Association ="CertificationParticipant:CertificationId")]
		public virtual ICollection<CertificationParticipant> CertificationParticipantByCertification { get; set; }
		[CProperty(Association ="CertificationVideoRecordings:CertificationId")]
		public virtual ICollection<CertificationVideoRecordings> CertificationVideoRecordingsByCertification { get; set; }
		#endregion
	}
}
