using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseRuleInStage")]
	public class CaseRuleInStage : BaseEntity
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
		private Guid _CaseNextStatusId;
		[CProperty(ColumnPath ="CaseNextStatusId")]
		public Guid CaseNextStatusId
		{
			get{return _CaseNextStatusId;}
			set
			{
				_CaseNextStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseRuleHandlerId;
		[CProperty(ColumnPath ="CaseRuleHandlerId")]
		public Guid CaseRuleHandlerId
		{
			get{return _CaseRuleHandlerId;}
			set
			{
				_CaseRuleHandlerId = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		[CProperty(Navigation ="CaseNextStatus:CaseNextStatusId")]
		public CaseNextStatus CaseNextStatus { get; set; }
		[CProperty(Navigation ="CaseRuleHandler:CaseRuleHandlerId")]
		public CaseRuleHandler CaseRuleHandler { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
