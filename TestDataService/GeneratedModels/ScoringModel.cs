using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ScoringModel")]
	public class ScoringModel : BaseEntity
	{
		#region Values
		private string _ColumnCaption;
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption
		{
			get{return _ColumnCaption;}
			set
			{
				_ColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _ColumnUId;
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId
		{
			get{return _ColumnUId;}
			set
			{
				_ColumnUId = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private Guid _ScoringObjectId;
		[CProperty(ColumnPath ="ScoringObjectId")]
		public Guid ScoringObjectId
		{
			get{return _ScoringObjectId;}
			set
			{
				_ScoringObjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceModelId;
		[CProperty(ColumnPath ="SourceModelId")]
		public Guid SourceModelId
		{
			get{return _SourceModelId;}
			set
			{
				_SourceModelId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ScoringModel:SourceModelId")]
		public ScoringModel SourceModel { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:ScoringObjectId")]
		public VwSysModuleEntity ScoringObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ScoringModel:SourceModelId")]
		public virtual ICollection<ScoringModel> ScoringModelBySourceModel { get; set; }
		[CProperty(Association ="ScoringRule:ScoringModelId")]
		public virtual ICollection<ScoringRule> ScoringRuleByScoringModel { get; set; }
		#endregion
	}
}
