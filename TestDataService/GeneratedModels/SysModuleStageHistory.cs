using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleStageHistory")]
	public class SysModuleStageHistory : BaseEntity
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
		private Guid _OwnerColUId;
		[CProperty(ColumnPath ="OwnerColUId")]
		public Guid OwnerColUId
		{
			get{return _OwnerColUId;}
			set
			{
				_OwnerColUId = value;
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
		private Guid _StageColUId;
		[CProperty(ColumnPath ="StageColUId")]
		public Guid StageColUId
		{
			get{return _StageColUId;}
			set
			{
				_StageColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryDueDateColUId;
		[CProperty(ColumnPath ="StageHistoryDueDateColUId")]
		public Guid StageHistoryDueDateColUId
		{
			get{return _StageHistoryDueDateColUId;}
			set
			{
				_StageHistoryDueDateColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryHistoricalColUId;
		[CProperty(ColumnPath ="StageHistoryHistoricalColUId")]
		public Guid StageHistoryHistoricalColUId
		{
			get{return _StageHistoryHistoricalColUId;}
			set
			{
				_StageHistoryHistoricalColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryMainEntityColUId;
		[CProperty(ColumnPath ="StageHistoryMainEntityColUId")]
		public Guid StageHistoryMainEntityColUId
		{
			get{return _StageHistoryMainEntityColUId;}
			set
			{
				_StageHistoryMainEntityColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryOwnerColUId;
		[CProperty(ColumnPath ="StageHistoryOwnerColUId")]
		public Guid StageHistoryOwnerColUId
		{
			get{return _StageHistoryOwnerColUId;}
			set
			{
				_StageHistoryOwnerColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistorySchemaUId;
		[CProperty(ColumnPath ="StageHistorySchemaUId")]
		public Guid StageHistorySchemaUId
		{
			get{return _StageHistorySchemaUId;}
			set
			{
				_StageHistorySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryStageColUId;
		[CProperty(ColumnPath ="StageHistoryStageColUId")]
		public Guid StageHistoryStageColUId
		{
			get{return _StageHistoryStageColUId;}
			set
			{
				_StageHistoryStageColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageHistoryStartDateColUId;
		[CProperty(ColumnPath ="StageHistoryStartDateColUId")]
		public Guid StageHistoryStartDateColUId
		{
			get{return _StageHistoryStartDateColUId;}
			set
			{
				_StageHistoryStartDateColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageIsFinalColUId;
		[CProperty(ColumnPath ="StageIsFinalColUId")]
		public Guid StageIsFinalColUId
		{
			get{return _StageIsFinalColUId;}
			set
			{
				_StageIsFinalColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageIsSuccessfulColUId;
		[CProperty(ColumnPath ="StageIsSuccessfulColUId")]
		public Guid StageIsSuccessfulColUId
		{
			get{return _StageIsSuccessfulColUId;}
			set
			{
				_StageIsSuccessfulColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageOrderColUId;
		[CProperty(ColumnPath ="StageOrderColUId")]
		public Guid StageOrderColUId
		{
			get{return _StageOrderColUId;}
			set
			{
				_StageOrderColUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageSchemaUId;
		[CProperty(ColumnPath ="StageSchemaUId")]
		public Guid StageSchemaUId
		{
			get{return _StageSchemaUId;}
			set
			{
				_StageSchemaUId = value;
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
		#endregion
	}
}
