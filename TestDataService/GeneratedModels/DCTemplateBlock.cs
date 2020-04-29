using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCTemplateBlock")]
	public class DCTemplateBlock : BaseEntity
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
		private Guid _DCTemplateGroupId;
		[CProperty(ColumnPath ="DCTemplateGroupId")]
		public Guid DCTemplateGroupId
		{
			get{return _DCTemplateGroupId;}
			set
			{
				_DCTemplateGroupId = value;
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
		private int _Index;
		[CProperty(ColumnPath ="Index")]
		public int Index
		{
			get{return _Index;}
			set
			{
				_Index = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDefault;
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault
		{
			get{return _IsDefault;}
			set
			{
				_IsDefault = value;
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
		private int _Priority;
		[CProperty(ColumnPath ="Priority")]
		public int Priority
		{
			get{return _Priority;}
			set
			{
				_Priority = value;
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
		[CProperty(Navigation ="DCTemplateGroup:DCTemplateGroupId")]
		public DCTemplateGroup DCTemplateGroup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DCAttributeInBlock:DCTemplateBlockId")]
		public virtual ICollection<DCAttributeInBlock> DCAttributeInBlockByDCTemplateBlock { get; set; }
		[CProperty(Association ="DCBlockInReplica:DCTemplateBlockId")]
		public virtual ICollection<DCBlockInReplica> DCBlockInReplicaByDCTemplateBlock { get; set; }
		#endregion
	}
}
