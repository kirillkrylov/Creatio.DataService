using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CorrespondenceLink")]
	public class CorrespondenceLink : BaseEntity
	{
		#region Values
		private Guid _ActId;
		[CProperty(ColumnPath ="ActId")]
		public Guid ActId
		{
			get{return _ActId;}
			set
			{
				_ActId = value;
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
		private Guid _CorrespondenceId;
		[CProperty(ColumnPath ="CorrespondenceId")]
		public Guid CorrespondenceId
		{
			get{return _CorrespondenceId;}
			set
			{
				_CorrespondenceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CorrespondenceSourceId;
		[CProperty(ColumnPath ="CorrespondenceSourceId")]
		public Guid CorrespondenceSourceId
		{
			get{return _CorrespondenceSourceId;}
			set
			{
				_CorrespondenceSourceId = value;
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
		private Guid _InvoiceId;
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId
		{
			get{return _InvoiceId;}
			set
			{
				_InvoiceId = value;
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
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
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
		private int _Quantity;
		[CProperty(ColumnPath ="Quantity")]
		public int Quantity
		{
			get{return _Quantity;}
			set
			{
				_Quantity = value;
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
		private Guid _RequestId;
		[CProperty(ColumnPath ="RequestId")]
		public Guid RequestId
		{
			get{return _RequestId;}
			set
			{
				_RequestId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
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
		[CProperty(Navigation ="CorrespondenceLinkType:TypeId")]
		public CorrespondenceLinkType Type { get; set; }
		[CProperty(Navigation ="Document:CorrespondenceId")]
		public Document Correspondence { get; set; }
		[CProperty(Navigation ="Document:ActId")]
		public Document Act { get; set; }
		[CProperty(Navigation ="Document:CorrespondenceSourceId")]
		public Document CorrespondenceSource { get; set; }
		[CProperty(Navigation ="InternalRequest:RequestId")]
		public InternalRequest Request { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
