using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadSource")]
	public class LeadSource : BaseEntity
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
		private Guid _LeadMediumId;
		[CProperty(ColumnPath ="LeadMediumId")]
		public Guid LeadMediumId
		{
			get{return _LeadMediumId;}
			set
			{
				_LeadMediumId = value;
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
		[CProperty(Navigation ="LeadMedium:LeadMediumId")]
		public LeadMedium LeadMedium { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmRefRule:LeadSourceId")]
		public virtual ICollection<BpmRefRule> BpmRefRuleByLeadSource { get; set; }
		[CProperty(Association ="ExesInRequest:LeadSourceId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByLeadSource { get; set; }
		[CProperty(Association ="Lead:LeadSourceId")]
		public virtual ICollection<Lead> LeadByLeadSource { get; set; }
		[CProperty(Association ="Lead:ClientLeadSourceId")]
		public virtual ICollection<Lead> LeadByClientLeadSource { get; set; }
		[CProperty(Association ="LeadSourceCode:LeadSourceId")]
		public virtual ICollection<LeadSourceCode> LeadSourceCodeByLeadSource { get; set; }
		[CProperty(Association ="LeadSourceUrl:LeadSourceId")]
		public virtual ICollection<LeadSourceUrl> LeadSourceUrlByLeadSource { get; set; }
		[CProperty(Association ="MktgActivityRule:LeadSourceId")]
		public virtual ICollection<MktgActivityRule> MktgActivityRuleByLeadSource { get; set; }
		[CProperty(Association ="Opportunity:LeadSourceId")]
		public virtual ICollection<Opportunity> OpportunityByLeadSource { get; set; }
		[CProperty(Association ="VwLead:LeadSourceId")]
		public virtual ICollection<VwLead> VwLeadByLeadSource { get; set; }
		[CProperty(Association ="VwLead:ClientLeadSourceId")]
		public virtual ICollection<VwLead> VwLeadByClientLeadSource { get; set; }
		#endregion
	}
}
