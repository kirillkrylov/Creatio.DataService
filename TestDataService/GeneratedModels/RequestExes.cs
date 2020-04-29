using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestExes")]
	public class RequestExes : BaseEntity
	{
		#region Values
		private int _Amount;
		[CProperty(ColumnPath ="Amount")]
		public int Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
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
		private bool _NeedPrimaryDocuments;
		[CProperty(ColumnPath ="NeedPrimaryDocuments")]
		public bool NeedPrimaryDocuments
		{
			get{return _NeedPrimaryDocuments;}
			set
			{
				_NeedPrimaryDocuments = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentTypeId;
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId
		{
			get{return _PaymentTypeId;}
			set
			{
				_PaymentTypeId = value;
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
		private Guid _RequestTypeId;
		[CProperty(ColumnPath ="RequestTypeId")]
		public Guid RequestTypeId
		{
			get{return _RequestTypeId;}
			set
			{
				_RequestTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Sync1cId;
		[CProperty(ColumnPath ="Sync1cId")]
		public string Sync1cId
		{
			get{return _Sync1cId;}
			set
			{
				_Sync1cId = value;
				OnPropertyChanged();
			}
		}
		private bool _UsedInBusinessTrip;
		[CProperty(ColumnPath ="UsedInBusinessTrip")]
		public bool UsedInBusinessTrip
		{
			get{return _UsedInBusinessTrip;}
			set
			{
				_UsedInBusinessTrip = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="RequestType:RequestTypeId")]
		public RequestType RequestType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequest:RequestExesId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByRequestExes { get; set; }
		[CProperty(Association ="RequestExesByType:RequestExesId")]
		public virtual ICollection<RequestExesByType> RequestExesByTypeByRequestExes { get; set; }
		#endregion
	}
}
