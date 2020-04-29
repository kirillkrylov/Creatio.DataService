using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwEARequestLog")]
	public class VwEARequestLog : BaseEntity
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
		private string _CustomerId;
		[CProperty(ColumnPath ="CustomerId")]
		public string CustomerId
		{
			get{return _CustomerId;}
			set
			{
				_CustomerId = value;
				OnPropertyChanged();
			}
		}
		private string _ExternalAccessDescription;
		[CProperty(ColumnPath ="ExternalAccessDescription")]
		public string ExternalAccessDescription
		{
			get{return _ExternalAccessDescription;}
			set
			{
				_ExternalAccessDescription = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExternalAccessId;
		[CProperty(ColumnPath ="ExternalAccessId")]
		public Guid ExternalAccessId
		{
			get{return _ExternalAccessId;}
			set
			{
				_ExternalAccessId = value;
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
		private Guid _RequestedById;
		[CProperty(ColumnPath ="RequestedById")]
		public Guid RequestedById
		{
			get{return _RequestedById;}
			set
			{
				_RequestedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RequestedOn;
		[CProperty(ColumnPath ="RequestedOn")]
		public DateTime RequestedOn
		{
			get{return _RequestedOn;}
			set
			{
				_RequestedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionId;
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId
		{
			get{return _SubscriptionId;}
			set
			{
				_SubscriptionId = value;
				OnPropertyChanged();
			}
		}
		private string _Url;
		[CProperty(ColumnPath ="Url")]
		public string Url
		{
			get{return _Url;}
			set
			{
				_Url = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:RequestedById")]
		public Contact RequestedBy { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
