using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContractVisasList")]
	public class ContractVisasList : BaseEntity
	{
		#region Values
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
				OnPropertyChanged();
			}
		}
		private string _Commentary;
		[CProperty(ColumnPath ="Commentary")]
		public string Commentary
		{
			get{return _Commentary;}
			set
			{
				_Commentary = value;
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
		private Guid _ContractVisaId;
		[CProperty(ColumnPath ="ContractVisaId")]
		public Guid ContractVisaId
		{
			get{return _ContractVisaId;}
			set
			{
				_ContractVisaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractVisaTypeId;
		[CProperty(ColumnPath ="ContractVisaTypeId")]
		public Guid ContractVisaTypeId
		{
			get{return _ContractVisaTypeId;}
			set
			{
				_ContractVisaTypeId = value;
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
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="ContractVisa:ContractVisaId")]
		public ContractVisa ContractVisa { get; set; }
		[CProperty(Navigation ="ContractVisaTypes:ContractVisaTypeId")]
		public ContractVisaTypes ContractVisaType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
