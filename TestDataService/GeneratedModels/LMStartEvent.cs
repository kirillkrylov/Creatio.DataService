using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LMStartEvent")]
	public class LMStartEvent : BaseEntity
	{
		#region Values
		private string _ChangedColumns;
		[CProperty(ColumnPath ="ChangedColumns")]
		public string ChangedColumns
		{
			get{return _ChangedColumns;}
			set
			{
				_ChangedColumns = value;
				OnPropertyChanged();
			}
		}
		private string _ConditionData;
		[CProperty(ColumnPath ="ConditionData")]
		public string ConditionData
		{
			get{return _ConditionData;}
			set
			{
				_ConditionData = value;
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
		private Guid _EntitySchemaUId;
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId
		{
			get{return _EntitySchemaUId;}
			set
			{
				_EntitySchemaUId = value;
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
		private string _MessageTemplate;
		[CProperty(ColumnPath ="MessageTemplate")]
		public string MessageTemplate
		{
			get{return _MessageTemplate;}
			set
			{
				_MessageTemplate = value;
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
		private int _RecordChangeType;
		[CProperty(ColumnPath ="RecordChangeType")]
		public int RecordChangeType
		{
			get{return _RecordChangeType;}
			set
			{
				_RecordChangeType = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LMColumnTemplate:LMStartEventId")]
		public virtual ICollection<LMColumnTemplate> LMColumnTemplateByLMStartEvent { get; set; }
		#endregion
	}
}
