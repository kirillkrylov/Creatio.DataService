using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLClassificationResult")]
	public class MLClassificationResult : BaseEntity
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
		private Guid _Key;
		[CProperty(ColumnPath ="Key")]
		public Guid Key
		{
			get{return _Key;}
			set
			{
				_Key = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModelId;
		[CProperty(ColumnPath ="ModelId")]
		public Guid ModelId
		{
			get{return _ModelId;}
			set
			{
				_ModelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModelInstanceUId;
		[CProperty(ColumnPath ="ModelInstanceUId")]
		public Guid ModelInstanceUId
		{
			get{return _ModelInstanceUId;}
			set
			{
				_ModelInstanceUId = value;
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
		private decimal _Probability;
		[CProperty(ColumnPath ="Probability")]
		public decimal Probability
		{
			get{return _Probability;}
			set
			{
				_Probability = value;
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
		private string _Significance;
		[CProperty(ColumnPath ="Significance")]
		public string Significance
		{
			get{return _Significance;}
			set
			{
				_Significance = value;
				OnPropertyChanged();
			}
		}
		private Guid _Value;
		[CProperty(ColumnPath ="Value")]
		public Guid Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MLModel:ModelId")]
		public MLModel Model { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
