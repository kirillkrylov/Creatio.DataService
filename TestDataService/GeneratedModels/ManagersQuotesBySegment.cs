using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ManagersQuotesBySegment")]
	public class ManagersQuotesBySegment : BaseEntity
	{
		#region Values
		private decimal _CashNB;
		[CProperty(ColumnPath ="CashNB")]
		public decimal CashNB
		{
			get{return _CashNB;}
			set
			{
				_CashNB = value;
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
		private decimal _FullQuotaPercent;
		[CProperty(ColumnPath ="FullQuotaPercent")]
		public decimal FullQuotaPercent
		{
			get{return _FullQuotaPercent;}
			set
			{
				_FullQuotaPercent = value;
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
		private Guid _ManagerRoleId;
		[CProperty(ColumnPath ="ManagerRoleId")]
		public Guid ManagerRoleId
		{
			get{return _ManagerRoleId;}
			set
			{
				_ManagerRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ManagerSegmentId;
		[CProperty(ColumnPath ="ManagerSegmentId")]
		public Guid ManagerSegmentId
		{
			get{return _ManagerSegmentId;}
			set
			{
				_ManagerSegmentId = value;
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
		private int _MonthNumber;
		[CProperty(ColumnPath ="MonthNumber")]
		public int MonthNumber
		{
			get{return _MonthNumber;}
			set
			{
				_MonthNumber = value;
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
		private Guid _SMJVersionId;
		[CProperty(ColumnPath ="SMJVersionId")]
		public Guid SMJVersionId
		{
			get{return _SMJVersionId;}
			set
			{
				_SMJVersionId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:ManagerRoleId")]
		public TsSalesCareerRole ManagerRole { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:ManagerSegmentId")]
		public TsSalesCareerSegment ManagerSegment { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:SMJVersionId")]
		public TsVersionSMJ SMJVersion { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
