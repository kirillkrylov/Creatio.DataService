using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlobalDuplicateSearchState")]
	public class GlobalDuplicateSearchState : BaseEntity
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
		private int _EntityRowNumber;
		[CProperty(ColumnPath ="EntityRowNumber")]
		public int EntityRowNumber
		{
			get{return _EntityRowNumber;}
			set
			{
				_EntityRowNumber = value;
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
		private bool _IsManuallyTriggered;
		[CProperty(ColumnPath ="IsManuallyTriggered")]
		public bool IsManuallyTriggered
		{
			get{return _IsManuallyTriggered;}
			set
			{
				_IsManuallyTriggered = value;
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
		private int _ProcessedCount;
		[CProperty(ColumnPath ="ProcessedCount")]
		public int ProcessedCount
		{
			get{return _ProcessedCount;}
			set
			{
				_ProcessedCount = value;
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
		private Guid _SchemaToSearchId;
		[CProperty(ColumnPath ="SchemaToSearchId")]
		public Guid SchemaToSearchId
		{
			get{return _SchemaToSearchId;}
			set
			{
				_SchemaToSearchId = value;
				OnPropertyChanged();
			}
		}
		private string _SchemaToSearchName;
		[CProperty(ColumnPath ="SchemaToSearchName")]
		public string SchemaToSearchName
		{
			get{return _SchemaToSearchName;}
			set
			{
				_SchemaToSearchName = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SearchStatusChangedOn;
		[CProperty(ColumnPath ="SearchStatusChangedOn")]
		public DateTime SearchStatusChangedOn
		{
			get{return _SearchStatusChangedOn;}
			set
			{
				_SearchStatusChangedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _SearchStatusId;
		[CProperty(ColumnPath ="SearchStatusId")]
		public Guid SearchStatusId
		{
			get{return _SearchStatusId;}
			set
			{
				_SearchStatusId = value;
				OnPropertyChanged();
			}
		}
		private int _TotalCount;
		[CProperty(ColumnPath ="TotalCount")]
		public int TotalCount
		{
			get{return _TotalCount;}
			set
			{
				_TotalCount = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlobalDuplicateSearchStatus:SearchStatusId")]
		public GlobalDuplicateSearchStatus SearchStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
