using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CertificationVideoRecordings")]
	public class CertificationVideoRecordings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CertificationId")]
		public Guid CertificationId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DownloadUrl")]
		public string DownloadUrl { get; set; }
		[CProperty(ColumnPath ="FileId")]
		public string FileId { get; set; }
		[CProperty(ColumnPath ="FileSize")]
		public int FileSize { get; set; }
		[CProperty(ColumnPath ="FileType")]
		public string FileType { get; set; }
		[CProperty(ColumnPath ="GuidedLearningOccurancesId")]
		public Guid GuidedLearningOccurancesId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MeetingId")]
		public string MeetingId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PlayUrl")]
		public string PlayUrl { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordHash")]
		public string RecordHash { get; set; }
		[CProperty(ColumnPath ="RecordingEnd")]
		public DateTime RecordingEnd { get; set; }
		[CProperty(ColumnPath ="RecordingStart")]
		public DateTime RecordingStart { get; set; }
		[CProperty(ColumnPath ="RecordingType")]
		public string RecordingType { get; set; }
		[CProperty(ColumnPath ="Status")]
		public string Status { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Certification:CertificationId")]
		public Certification Certification { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GuidedLearningOccurances:GuidedLearningOccurancesId")]
		public GuidedLearningOccurances GuidedLearningOccurances { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
