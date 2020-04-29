using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProcessDashboard")]
	public class VwProcessDashboard : BaseEntity
	{
		#region Values
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
		private string _ElementCaption;
		[CProperty(ColumnPath ="ElementCaption")]
		public string ElementCaption
		{
			get{return _ElementCaption;}
			set
			{
				_ElementCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _ElementOwnerId;
		[CProperty(ColumnPath ="ElementOwnerId")]
		public Guid ElementOwnerId
		{
			get{return _ElementOwnerId;}
			set
			{
				_ElementOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
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
		private Guid _ProcessDataId;
		[CProperty(ColumnPath ="ProcessDataId")]
		public Guid ProcessDataId
		{
			get{return _ProcessDataId;}
			set
			{
				_ProcessDataId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementEntityId;
		[CProperty(ColumnPath ="ProcessElementEntityId")]
		public Guid ProcessElementEntityId
		{
			get{return _ProcessElementEntityId;}
			set
			{
				_ProcessElementEntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementEntitySchemaUId;
		[CProperty(ColumnPath ="ProcessElementEntitySchemaUId")]
		public Guid ProcessElementEntitySchemaUId
		{
			get{return _ProcessElementEntitySchemaUId;}
			set
			{
				_ProcessElementEntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementId;
		[CProperty(ColumnPath ="ProcessElementId")]
		public Guid ProcessElementId
		{
			get{return _ProcessElementId;}
			set
			{
				_ProcessElementId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementSchemaUId;
		[CProperty(ColumnPath ="ProcessElementSchemaUId")]
		public Guid ProcessElementSchemaUId
		{
			get{return _ProcessElementSchemaUId;}
			set
			{
				_ProcessElementSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private string _ProcessName;
		[CProperty(ColumnPath ="ProcessName")]
		public string ProcessName
		{
			get{return _ProcessName;}
			set
			{
				_ProcessName = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessOwnerId;
		[CProperty(ColumnPath ="ProcessOwnerId")]
		public Guid ProcessOwnerId
		{
			get{return _ProcessOwnerId;}
			set
			{
				_ProcessOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessSchemaElementUId;
		[CProperty(ColumnPath ="ProcessSchemaElementUId")]
		public Guid ProcessSchemaElementUId
		{
			get{return _ProcessSchemaElementUId;}
			set
			{
				_ProcessSchemaElementUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ElementOwnerId")]
		public Contact ElementOwner { get; set; }
		[CProperty(Navigation ="Contact:ProcessOwnerId")]
		public Contact ProcessOwner { get; set; }
		[CProperty(Navigation ="SysProcessData:ProcessDataId")]
		public SysProcessData ProcessData { get; set; }
		[CProperty(Navigation ="SysProcessElementData:ProcessElementId")]
		public SysProcessElementData ProcessElement { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
