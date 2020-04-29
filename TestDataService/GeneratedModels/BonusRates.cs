using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusRates")]
	public class BonusRates : BaseEntity
	{
		#region Values
		private decimal _BonusPercent;
		[CProperty(ColumnPath ="BonusPercent")]
		public decimal BonusPercent
		{
			get{return _BonusPercent;}
			set
			{
				_BonusPercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _BonusRatio;
		[CProperty(ColumnPath ="BonusRatio")]
		public decimal BonusRatio
		{
			get{return _BonusRatio;}
			set
			{
				_BonusRatio = value;
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
		private decimal _LowerBoundaryOfQuartile;
		[CProperty(ColumnPath ="LowerBoundaryOfQuartile")]
		public decimal LowerBoundaryOfQuartile
		{
			get{return _LowerBoundaryOfQuartile;}
			set
			{
				_LowerBoundaryOfQuartile = value;
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
		private Guid _SalesCareerRoleId;
		[CProperty(ColumnPath ="SalesCareerRoleId")]
		public Guid SalesCareerRoleId
		{
			get{return _SalesCareerRoleId;}
			set
			{
				_SalesCareerRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SalesCareerSegmentId;
		[CProperty(ColumnPath ="SalesCareerSegmentId")]
		public Guid SalesCareerSegmentId
		{
			get{return _SalesCareerSegmentId;}
			set
			{
				_SalesCareerSegmentId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TeamLeaderPercent;
		[CProperty(ColumnPath ="TeamLeaderPercent")]
		public decimal TeamLeaderPercent
		{
			get{return _TeamLeaderPercent;}
			set
			{
				_TeamLeaderPercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _UpperBoundaryOfQuartile;
		[CProperty(ColumnPath ="UpperBoundaryOfQuartile")]
		public decimal UpperBoundaryOfQuartile
		{
			get{return _UpperBoundaryOfQuartile;}
			set
			{
				_UpperBoundaryOfQuartile = value;
				OnPropertyChanged();
			}
		}
		private Guid _VersionSMJId;
		[CProperty(ColumnPath ="VersionSMJId")]
		public Guid VersionSMJId
		{
			get{return _VersionSMJId;}
			set
			{
				_VersionSMJId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:SalesCareerRoleId")]
		public TsSalesCareerRole SalesCareerRole { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SalesCareerSegmentId")]
		public TsSalesCareerSegment SalesCareerSegment { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:VersionSMJId")]
		public TsVersionSMJ VersionSMJ { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
