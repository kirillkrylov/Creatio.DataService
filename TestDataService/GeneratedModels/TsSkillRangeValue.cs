using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSkillRangeValue")]
	public class TsSkillRangeValue : BaseEntity
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
		private string _ExpressionText;
		[CProperty(ColumnPath ="ExpressionText")]
		public string ExpressionText
		{
			get{return _ExpressionText;}
			set
			{
				_ExpressionText = value;
				OnPropertyChanged();
			}
		}
		private int _ExpressionType;
		[CProperty(ColumnPath ="ExpressionType")]
		public int ExpressionType
		{
			get{return _ExpressionType;}
			set
			{
				_ExpressionType = value;
				OnPropertyChanged();
			}
		}
		private decimal _GeValue;
		[CProperty(ColumnPath ="GeValue")]
		public decimal GeValue
		{
			get{return _GeValue;}
			set
			{
				_GeValue = value;
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
		private decimal _LeValue;
		[CProperty(ColumnPath ="LeValue")]
		public decimal LeValue
		{
			get{return _LeValue;}
			set
			{
				_LeValue = value;
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
		private Guid _SkillId;
		[CProperty(ColumnPath ="SkillId")]
		public Guid SkillId
		{
			get{return _SkillId;}
			set
			{
				_SkillId = value;
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
		[CProperty(Navigation ="TsSkill:SkillId")]
		public TsSkill Skill { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
