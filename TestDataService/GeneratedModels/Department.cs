using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Department")]
	public class Department : BaseEntity
	{
		#region Values
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountOrganizationChart:DepartmentId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByDepartment { get; set; }
		[CProperty(Association ="ConfItemUser:DepartmentId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByDepartment { get; set; }
		[CProperty(Association ="Contact:DepartmentId")]
		public virtual ICollection<Contact> ContactByDepartment { get; set; }
		[CProperty(Association ="ContactCareer:DepartmentId")]
		public virtual ICollection<ContactCareer> ContactCareerByDepartment { get; set; }
		[CProperty(Association ="Lead:DepartmentId")]
		public virtual ICollection<Lead> LeadByDepartment { get; set; }
		[CProperty(Association ="LeadQualification:DepartmentId")]
		public virtual ICollection<LeadQualification> LeadQualificationByDepartment { get; set; }
		[CProperty(Association ="ServiceObject:DepartmentId")]
		public virtual ICollection<ServiceObject> ServiceObjectByDepartment { get; set; }
		[CProperty(Association ="VwEventInContact:DepartmentId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByDepartment { get; set; }
		[CProperty(Association ="VwLead:DepartmentId")]
		public virtual ICollection<VwLead> VwLeadByDepartment { get; set; }
		[CProperty(Association ="VwServiceRecepients:DepartmentId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByDepartment { get; set; }
		#endregion
	}
}
