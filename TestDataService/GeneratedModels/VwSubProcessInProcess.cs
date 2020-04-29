using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSubProcessInProcess")]
	public class VwSubProcessInProcess : BaseEntity
	{
		#region Values
		private Guid _ActiveSubProcessId;
		[CProperty(ColumnPath ="ActiveSubProcessId")]
		public Guid ActiveSubProcessId
		{
			get{return _ActiveSubProcessId;}
			set
			{
				_ActiveSubProcessId = value;
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
		private Guid _HostProcessId;
		[CProperty(ColumnPath ="HostProcessId")]
		public Guid HostProcessId
		{
			get{return _HostProcessId;}
			set
			{
				_HostProcessId = value;
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
		private Guid _ParentProcessId;
		[CProperty(ColumnPath ="ParentProcessId")]
		public Guid ParentProcessId
		{
			get{return _ParentProcessId;}
			set
			{
				_ParentProcessId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentSubProcessId;
		[CProperty(ColumnPath ="ParentSubProcessId")]
		public Guid ParentSubProcessId
		{
			get{return _ParentSubProcessId;}
			set
			{
				_ParentSubProcessId = value;
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
		private Guid _SubProcessId;
		[CProperty(ColumnPath ="SubProcessId")]
		public Guid SubProcessId
		{
			get{return _SubProcessId;}
			set
			{
				_SubProcessId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwProcessLib:HostProcessId")]
		public VwProcessLib HostProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ParentProcessId")]
		public VwProcessLib ParentProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:SubProcessId")]
		public VwProcessLib SubProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ParentSubProcessId")]
		public VwProcessLib ParentSubProcess { get; set; }
		[CProperty(Navigation ="VwProcessLib:ActiveSubProcessId")]
		public VwProcessLib ActiveSubProcess { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
