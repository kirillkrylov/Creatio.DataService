using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LMColumnTemplate")]
	public class LMColumnTemplate : BaseEntity
	{
		#region Values
		private string _ColumnName;
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName
		{
			get{return _ColumnName;}
			set
			{
				_ColumnName = value;
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
		private bool _IsLink;
		[CProperty(ColumnPath ="IsLink")]
		public bool IsLink
		{
			get{return _IsLink;}
			set
			{
				_IsLink = value;
				OnPropertyChanged();
			}
		}
		private bool _IsOnChange;
		[CProperty(ColumnPath ="IsOnChange")]
		public bool IsOnChange
		{
			get{return _IsOnChange;}
			set
			{
				_IsOnChange = value;
				OnPropertyChanged();
			}
		}
		private Guid _LMStartEventId;
		[CProperty(ColumnPath ="LMStartEventId")]
		public Guid LMStartEventId
		{
			get{return _LMStartEventId;}
			set
			{
				_LMStartEventId = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LMStartEvent:LMStartEventId")]
		public LMStartEvent LMStartEvent { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
