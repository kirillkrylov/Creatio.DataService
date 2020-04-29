using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLModelColumn")]
	public class MLModelColumn : BaseEntity
	{
		#region Values
		private int _AggregationType;
		[CProperty(ColumnPath ="AggregationType")]
		public int AggregationType
		{
			get{return _AggregationType;}
			set
			{
				_AggregationType = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnPath;
		[CProperty(ColumnPath ="ColumnPath")]
		public string ColumnPath
		{
			get{return _ColumnPath;}
			set
			{
				_ColumnPath = value;
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
		private Guid _MLModelId;
		[CProperty(ColumnPath ="MLModelId")]
		public Guid MLModelId
		{
			get{return _MLModelId;}
			set
			{
				_MLModelId = value;
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
		private string _SubFilters;
		[CProperty(ColumnPath ="SubFilters")]
		public string SubFilters
		{
			get{return _SubFilters;}
			set
			{
				_SubFilters = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MLModel:MLModelId")]
		public MLModel MLModel { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
