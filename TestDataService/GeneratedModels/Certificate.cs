using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Certificate")]
	public class Certificate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CertificateNumber")]
		public string CertificateNumber { get; set; }
		[CProperty(ColumnPath ="Comments")]
		public string Comments { get; set; }
		[CProperty(ColumnPath ="CompetenceLevelId")]
		public Guid CompetenceLevelId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateOfNotification")]
		public DateTime DateOfNotification { get; set; }
		[CProperty(ColumnPath ="EducationActivityId")]
		public Guid EducationActivityId { get; set; }
		[CProperty(ColumnPath ="ExpireDate")]
		public DateTime ExpireDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IssueDate")]
		public DateTime IssueDate { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NotificationSent")]
		public bool NotificationSent { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ResultScore")]
		public decimal ResultScore { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CompetenceLevel:CompetenceLevelId")]
		public CompetenceLevel CompetenceLevel { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="EducationActivity:EducationActivityId")]
		public EducationActivity EducationActivity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
