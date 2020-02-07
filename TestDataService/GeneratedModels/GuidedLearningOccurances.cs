using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GuidedLearningOccurances")]
	public class GuidedLearningOccurances : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Agenda")]
		public string Agenda { get; set; }
		[CProperty(ColumnPath ="Completed")]
		public bool Completed { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="GuidedLearningId")]
		public Guid GuidedLearningId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Occurrence")]
		public string Occurrence { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RelatedActivityId")]
		public Guid RelatedActivityId { get; set; }
		[CProperty(ColumnPath ="StartTime")]
		public DateTime StartTime { get; set; }
		[CProperty(ColumnPath ="Status")]
		public string Status { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:RelatedActivityId")]
		public Activity RelatedActivity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GuidedLearning:GuidedLearningId")]
		public GuidedLearning GuidedLearning { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:OccurencesId")]
		public virtual ICollection<Activity> ActivityByOccurences { get; set; }
		[CProperty(Association ="CertificationParticipant:GuidedLearningOccurancesId")]
		public virtual ICollection<CertificationParticipant> CertificationParticipantByGuidedLearningOccurances { get; set; }
		[CProperty(Association ="CertificationVideoRecordings:GuidedLearningOccurancesId")]
		public virtual ICollection<CertificationVideoRecordings> CertificationVideoRecordingsByGuidedLearningOccurances { get; set; }
		#endregion
	}
}
