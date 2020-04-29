using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffSkillPeriodDetails")]
	public class TsStaffSkillPeriodDetails : BaseEntity
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
		private decimal _PointValue;
		[CProperty(ColumnPath ="PointValue")]
		public decimal PointValue
		{
			get{return _PointValue;}
			set
			{
				_PointValue = value;
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
		private decimal _Progress;
		[CProperty(ColumnPath ="Progress")]
		public decimal Progress
		{
			get{return _Progress;}
			set
			{
				_Progress = value;
				OnPropertyChanged();
			}
		}
		private Guid _SkillGroupId;
		[CProperty(ColumnPath ="SkillGroupId")]
		public Guid SkillGroupId
		{
			get{return _SkillGroupId;}
			set
			{
				_SkillGroupId = value;
				OnPropertyChanged();
			}
		}
		private decimal _SkillGroupProgress;
		[CProperty(ColumnPath ="SkillGroupProgress")]
		public decimal SkillGroupProgress
		{
			get{return _SkillGroupProgress;}
			set
			{
				_SkillGroupProgress = value;
				OnPropertyChanged();
			}
		}
		private Guid _StaffSkillPeriodId;
		[CProperty(ColumnPath ="StaffSkillPeriodId")]
		public Guid StaffSkillPeriodId
		{
			get{return _StaffSkillPeriodId;}
			set
			{
				_StaffSkillPeriodId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSkillGroup:SkillGroupId")]
		public TsSkillGroup SkillGroup { get; set; }
		[CProperty(Navigation ="TsStaffSkillPeriod:StaffSkillPeriodId")]
		public TsStaffSkillPeriod StaffSkillPeriod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
