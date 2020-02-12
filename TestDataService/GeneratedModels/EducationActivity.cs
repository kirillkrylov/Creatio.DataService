using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EducationActivity")]
	public class EducationActivity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="Cost")]
		public decimal Cost { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EducationActivityResultId")]
		public Guid EducationActivityResultId { get; set; }
		[CProperty(ColumnPath ="EducationActivityTypeId")]
		public Guid EducationActivityTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PaymentMethodId")]
		public Guid PaymentMethodId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusOfActivityId")]
		public Guid StatusOfActivityId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="EduActivityCategory:CategoryId")]
		public EduActivityCategory Category { get; set; }
		[CProperty(Navigation ="EduActivityResult:EducationActivityResultId")]
		public EduActivityResult EducationActivityResult { get; set; }
		[CProperty(Navigation ="EduActivityStatus:StatusOfActivityId")]
		public EduActivityStatus StatusOfActivity { get; set; }
		[CProperty(Navigation ="EduActivityType:EducationActivityTypeId")]
		public EduActivityType EducationActivityType { get; set; }
		[CProperty(Navigation ="PaymentMethod:PaymentMethodId")]
		public PaymentMethod PaymentMethod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Certificate:EducationActivityId")]
		public virtual ICollection<Certificate> CertificateByEducationActivity { get; set; }
		#endregion
	}
}
