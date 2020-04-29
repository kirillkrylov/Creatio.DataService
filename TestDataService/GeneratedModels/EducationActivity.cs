using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EducationActivity")]
	public class EducationActivity : BaseEntity
	{
		#region Values
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Cost;
		[CProperty(ColumnPath ="Cost")]
		public decimal Cost
		{
			get{return _Cost;}
			set
			{
				_Cost = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _EducationActivityResultId;
		[CProperty(ColumnPath ="EducationActivityResultId")]
		public Guid EducationActivityResultId
		{
			get{return _EducationActivityResultId;}
			set
			{
				_EducationActivityResultId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EducationActivityTypeId;
		[CProperty(ColumnPath ="EducationActivityTypeId")]
		public Guid EducationActivityTypeId
		{
			get{return _EducationActivityTypeId;}
			set
			{
				_EducationActivityTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentMethodId;
		[CProperty(ColumnPath ="PaymentMethodId")]
		public Guid PaymentMethodId
		{
			get{return _PaymentMethodId;}
			set
			{
				_PaymentMethodId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusOfActivityId;
		[CProperty(ColumnPath ="StatusOfActivityId")]
		public Guid StatusOfActivityId
		{
			get{return _StatusOfActivityId;}
			set
			{
				_StatusOfActivityId = value;
				OnPropertyChanged();
			}
		}
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
