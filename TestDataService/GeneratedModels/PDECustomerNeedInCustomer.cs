using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDECustomerNeedInCustomer")]
	public class PDECustomerNeedInCustomer : BaseEntity
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
		private string _PDEComment;
		[CProperty(ColumnPath ="PDEComment")]
		public string PDEComment
		{
			get{return _PDEComment;}
			set
			{
				_PDEComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDECustomerId;
		[CProperty(ColumnPath ="PDECustomerId")]
		public Guid PDECustomerId
		{
			get{return _PDECustomerId;}
			set
			{
				_PDECustomerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDECustomerNeedId;
		[CProperty(ColumnPath ="PDECustomerNeedId")]
		public Guid PDECustomerNeedId
		{
			get{return _PDECustomerNeedId;}
			set
			{
				_PDECustomerNeedId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDENeedTypeId;
		[CProperty(ColumnPath ="PDENeedTypeId")]
		public Guid PDENeedTypeId
		{
			get{return _PDENeedTypeId;}
			set
			{
				_PDENeedTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEPartnerId;
		[CProperty(ColumnPath ="PDEPartnerId")]
		public Guid PDEPartnerId
		{
			get{return _PDEPartnerId;}
			set
			{
				_PDEPartnerId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PDEProjectEndDate;
		[CProperty(ColumnPath ="PDEProjectEndDate")]
		public DateTime PDEProjectEndDate
		{
			get{return _PDEProjectEndDate;}
			set
			{
				_PDEProjectEndDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEProjectStatusId;
		[CProperty(ColumnPath ="PDEProjectStatusId")]
		public Guid PDEProjectStatusId
		{
			get{return _PDEProjectStatusId;}
			set
			{
				_PDEProjectStatusId = value;
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
		[CProperty(Navigation ="Account:PDEPartnerId")]
		public Account PDEPartner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlbCustomer:PDECustomerId")]
		public GlbCustomer PDECustomer { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeed:PDECustomerNeedId")]
		public PDEClientCaseNeed PDECustomerNeed { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeedType:PDENeedTypeId")]
		public PDEClientCaseNeedType PDENeedType { get; set; }
		[CProperty(Navigation ="PDEClientCaseProjectStatus:PDEProjectStatusId")]
		public PDEClientCaseProjectStatus PDEProjectStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
