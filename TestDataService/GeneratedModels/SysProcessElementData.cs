using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessElementData")]
	public class SysProcessElementData : BaseEntity
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
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
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
		private byte[] _PropertiesData;
		[CProperty(ColumnPath ="PropertiesData")]
		public byte[] PropertiesData
		{
			get{return _PropertiesData;}
			set
			{
				_PropertiesData = value;
				OnPropertyChanged();
			}
		}
		private Guid _SchemaElementUId;
		[CProperty(ColumnPath ="SchemaElementUId")]
		public Guid SchemaElementUId
		{
			get{return _SchemaElementUId;}
			set
			{
				_SchemaElementUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SchemaUId;
		[CProperty(ColumnPath ="SchemaUId")]
		public Guid SchemaUId
		{
			get{return _SchemaUId;}
			set
			{
				_SchemaUId = value;
				OnPropertyChanged();
			}
		}
		private int _Status;
		[CProperty(ColumnPath ="Status")]
		public int Status
		{
			get{return _Status;}
			set
			{
				_Status = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysProcessId;
		[CProperty(ColumnPath ="SysProcessId")]
		public Guid SysProcessId
		{
			get{return _SysProcessId;}
			set
			{
				_SysProcessId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysProcessData:SysProcessId")]
		public SysProcessData SysProcess { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EntryPoint:SysProcessElementDataId")]
		public virtual ICollection<EntryPoint> EntryPointBySysProcessElementData { get; set; }
		[CProperty(Association ="SysEntityCommonPrcEl:ProcessElementId")]
		public virtual ICollection<SysEntityCommonPrcEl> SysEntityCommonPrcElByProcessElement { get; set; }
		[CProperty(Association ="SysProcessIntermediateEvent:SysProcessElementId")]
		public virtual ICollection<SysProcessIntermediateEvent> SysProcessIntermediateEventBySysProcessElement { get; set; }
		[CProperty(Association ="VwProcessDashboard:ProcessElementId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByProcessElement { get; set; }
		#endregion
	}
}
