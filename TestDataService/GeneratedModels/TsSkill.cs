using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSkill")]
	public class TsSkill : BaseEntity
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
		private bool _AutoSendForApproval;
		[CProperty(ColumnPath ="AutoSendForApproval")]
		public bool AutoSendForApproval
		{
			get{return _AutoSendForApproval;}
			set
			{
				_AutoSendForApproval = value;
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
		private string _Decision;
		[CProperty(ColumnPath ="Decision")]
		public string Decision
		{
			get{return _Decision;}
			set
			{
				_Decision = value;
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
		private bool _RangeRule;
		[CProperty(ColumnPath ="RangeRule")]
		public bool RangeRule
		{
			get{return _RangeRule;}
			set
			{
				_RangeRule = value;
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
		private int _Weight;
		[CProperty(ColumnPath ="Weight")]
		public int Weight
		{
			get{return _Weight;}
			set
			{
				_Weight = value;
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
		#endregion

		#region Associations
		[CProperty(Association ="TsSkillPlanDefaultSkills:SkillId")]
		public virtual ICollection<TsSkillPlanDefaultSkills> TsSkillPlanDefaultSkillsBySkill { get; set; }
		[CProperty(Association ="TsSkillRangeValue:SkillId")]
		public virtual ICollection<TsSkillRangeValue> TsSkillRangeValueBySkill { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValue:SkillId")]
		public virtual ICollection<TsStaffSkillPeriodValue> TsStaffSkillPeriodValueBySkill { get; set; }
		#endregion
	}
}
