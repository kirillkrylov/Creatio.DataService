using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadType")]
	public class LeadType : BaseEntity
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeDetailizationId;
		[CProperty(ColumnPath ="LeadTypeDetailizationId")]
		public Guid LeadTypeDetailizationId
		{
			get{return _LeadTypeDetailizationId;}
			set
			{
				_LeadTypeDetailizationId = value;
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
		private bool _NotForOpportunity;
		[CProperty(ColumnPath ="NotForOpportunity")]
		public bool NotForOpportunity
		{
			get{return _NotForOpportunity;}
			set
			{
				_NotForOpportunity = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityDepartmentId;
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId
		{
			get{return _OpportunityDepartmentId;}
			set
			{
				_OpportunityDepartmentId = value;
				OnPropertyChanged();
			}
		}
		private bool _PrimaryQualification;
		[CProperty(ColumnPath ="PrimaryQualification")]
		public bool PrimaryQualification
		{
			get{return _PrimaryQualification;}
			set
			{
				_PrimaryQualification = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LeadDetailedType:LeadTypeDetailizationId")]
		public LeadDetailedType LeadTypeDetailization { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DepartmentTypeTerritory:LeadTypeId")]
		public virtual ICollection<DepartmentTypeTerritory> DepartmentTypeTerritoryByLeadType { get; set; }
		[CProperty(Association ="Lead:LeadTypeId")]
		public virtual ICollection<Lead> LeadByLeadType { get; set; }
		[CProperty(Association ="LeadInStage:LeadTypeId")]
		public virtual ICollection<LeadInStage> LeadInStageByLeadType { get; set; }
		[CProperty(Association ="LeadQualification:LeadTypeId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadType { get; set; }
		[CProperty(Association ="LeadTypeForecast:LeadTypeId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByLeadType { get; set; }
		[CProperty(Association ="Opportunity:LeadTypeId")]
		public virtual ICollection<Opportunity> OpportunityByLeadType { get; set; }
		[CProperty(Association ="ProductInLeadType:LeadTypeId")]
		public virtual ICollection<ProductInLeadType> ProductInLeadTypeByLeadType { get; set; }
		[CProperty(Association ="Queue:LeadTypeId")]
		public virtual ICollection<Queue> QueueByLeadType { get; set; }
		[CProperty(Association ="SiteEvent:LeadTypeId")]
		public virtual ICollection<SiteEvent> SiteEventByLeadType { get; set; }
		[CProperty(Association ="VwLead:LeadTypeId")]
		public virtual ICollection<VwLead> VwLeadByLeadType { get; set; }
		[CProperty(Association ="VwPortalOpportunity:LeadTypeId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByLeadType { get; set; }
		[CProperty(Association ="VwProductInLeadType:LeadTypeId")]
		public virtual ICollection<VwProductInLeadType> VwProductInLeadTypeByLeadType { get; set; }
		[CProperty(Association ="VwSiteEvent:LeadTypeId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventByLeadType { get; set; }
		#endregion
	}
}
