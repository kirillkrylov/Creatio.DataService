using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPrcTimerSchedule")]
	public class VwPrcTimerSchedule : BaseEntity
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
		private string _ElementName;
		[CProperty(ColumnPath ="ElementName")]
		public string ElementName
		{
			get{return _ElementName;}
			set
			{
				_ElementName = value;
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
		private DateTime _NextFireTime;
		[CProperty(ColumnPath ="NextFireTime")]
		public DateTime NextFireTime
		{
			get{return _NextFireTime;}
			set
			{
				_NextFireTime = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PreviousFireTime;
		[CProperty(ColumnPath ="PreviousFireTime")]
		public DateTime PreviousFireTime
		{
			get{return _PreviousFireTime;}
			set
			{
				_PreviousFireTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementUId;
		[CProperty(ColumnPath ="ProcessElementUId")]
		public Guid ProcessElementUId
		{
			get{return _ProcessElementUId;}
			set
			{
				_ProcessElementUId = value;
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
		private Guid _ProcessUId;
		[CProperty(ColumnPath ="ProcessUId")]
		public Guid ProcessUId
		{
			get{return _ProcessUId;}
			set
			{
				_ProcessUId = value;
				OnPropertyChanged();
			}
		}
		private string _TriggerState;
		[CProperty(ColumnPath ="TriggerState")]
		public string TriggerState
		{
			get{return _TriggerState;}
			set
			{
				_TriggerState = value;
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
