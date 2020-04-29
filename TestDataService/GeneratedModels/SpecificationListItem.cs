using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SpecificationListItem")]
	public class SpecificationListItem : BaseEntity
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
		private Guid _SpecificationId;
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId
		{
			get{return _SpecificationId;}
			set
			{
				_SpecificationId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LevelPartnershipParam:ListItemValueId")]
		public virtual ICollection<LevelPartnershipParam> LevelPartnershipParamByListItemValue { get; set; }
		[CProperty(Association ="PartnerParamHistory:ListItemValueId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByListItemValue { get; set; }
		[CProperty(Association ="PartnershipParameter:ListItemValueId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInLead:ListItemValueId")]
		public virtual ICollection<SpecificationInLead> SpecificationInLeadByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInObject:ListItemValueId")]
		public virtual ICollection<SpecificationInObject> SpecificationInObjectByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInProduct:ListItemValueId")]
		public virtual ICollection<SpecificationInProduct> SpecificationInProductByListItemValue { get; set; }
		[CProperty(Association ="SpecInContract:ListItemValueId")]
		public virtual ICollection<SpecInContract> SpecInContractByListItemValue { get; set; }
		#endregion
	}
}
