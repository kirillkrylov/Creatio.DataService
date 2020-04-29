using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCReplica")]
	public class DCReplica : BaseEntity
	{
		#region Values
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
		private string _Content;
		[CProperty(ColumnPath ="Content")]
		public string Content
		{
			get{return _Content;}
			set
			{
				_Content = value;
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
		private Guid _DCTemplateId;
		[CProperty(ColumnPath ="DCTemplateId")]
		public Guid DCTemplateId
		{
			get{return _DCTemplateId;}
			set
			{
				_DCTemplateId = value;
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
		private int _Mask;
		[CProperty(ColumnPath ="Mask")]
		public int Mask
		{
			get{return _Mask;}
			set
			{
				_Mask = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DCTemplate:DCTemplateId")]
		public DCTemplate DCTemplate { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmailRecipientReplica:DCReplicaId")]
		public virtual ICollection<BulkEmailRecipientReplica> BulkEmailRecipientReplicaByDCReplica { get; set; }
		[CProperty(Association ="BulkEmailReplicaHeaders:DCReplicaId")]
		public virtual ICollection<BulkEmailReplicaHeaders> BulkEmailReplicaHeadersByDCReplica { get; set; }
		[CProperty(Association ="DCBlockInReplica:DCReplicaId")]
		public virtual ICollection<DCBlockInReplica> DCBlockInReplicaByDCReplica { get; set; }
		[CProperty(Association ="DCRecipient:DCReplicaId")]
		public virtual ICollection<DCRecipient> DCRecipientByDCReplica { get; set; }
		#endregion
	}
}
