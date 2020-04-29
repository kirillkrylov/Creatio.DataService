using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SpecInContract")]
	public class SpecInContract : BaseEntity
	{
		#region Values
		private bool _BooleanValue;
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue
		{
			get{return _BooleanValue;}
			set
			{
				_BooleanValue = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractId;
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId
		{
			get{return _ContractId;}
			set
			{
				_ContractId = value;
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
		private decimal _FloatValue;
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue
		{
			get{return _FloatValue;}
			set
			{
				_FloatValue = value;
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
		private int _IntValue;
		[CProperty(ColumnPath ="IntValue")]
		public int IntValue
		{
			get{return _IntValue;}
			set
			{
				_IntValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _ListItemValueId;
		[CProperty(ColumnPath ="ListItemValueId")]
		public Guid ListItemValueId
		{
			get{return _ListItemValueId;}
			set
			{
				_ListItemValueId = value;
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
		private string _StringValue;
		[CProperty(ColumnPath ="StringValue")]
		public string StringValue
		{
			get{return _StringValue;}
			set
			{
				_StringValue = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		[CProperty(Navigation ="SpecificationListItem:ListItemValueId")]
		public SpecificationListItem ListItemValue { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SpecInContractHistory:SpecInContractId")]
		public virtual ICollection<SpecInContractHistory> SpecInContractHistoryBySpecInContract { get; set; }
		#endregion
	}
}
