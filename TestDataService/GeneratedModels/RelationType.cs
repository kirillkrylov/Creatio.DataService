using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RelationType")]
	public class RelationType : BaseEntity
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private bool _ForAccountAccount;
		[CProperty(ColumnPath ="ForAccountAccount")]
		public bool ForAccountAccount
		{
			get{return _ForAccountAccount;}
			set
			{
				_ForAccountAccount = value;
				OnPropertyChanged();
			}
		}
		private bool _ForAccountContact;
		[CProperty(ColumnPath ="ForAccountContact")]
		public bool ForAccountContact
		{
			get{return _ForAccountContact;}
			set
			{
				_ForAccountContact = value;
				OnPropertyChanged();
			}
		}
		private bool _ForContactAccount;
		[CProperty(ColumnPath ="ForContactAccount")]
		public bool ForContactAccount
		{
			get{return _ForContactAccount;}
			set
			{
				_ForContactAccount = value;
				OnPropertyChanged();
			}
		}
		private bool _ForContactContact;
		[CProperty(ColumnPath ="ForContactContact")]
		public bool ForContactContact
		{
			get{return _ForContactContact;}
			set
			{
				_ForContactContact = value;
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
		private Guid _ReverseRelationTypeId;
		[CProperty(ColumnPath ="ReverseRelationTypeId")]
		public Guid ReverseRelationTypeId
		{
			get{return _ReverseRelationTypeId;}
			set
			{
				_ReverseRelationTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RelationType:ReverseRelationTypeId")]
		public RelationType ReverseRelationType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Relationship:RelationTypeId")]
		public virtual ICollection<Relationship> RelationshipByRelationType { get; set; }
		[CProperty(Association ="Relationship:ReverseRelationTypeId")]
		public virtual ICollection<Relationship> RelationshipByReverseRelationType { get; set; }
		[CProperty(Association ="RelationType:ReverseRelationTypeId")]
		public virtual ICollection<RelationType> RelationTypeByReverseRelationType { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelationTypeId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelationType { get; set; }
		[CProperty(Association ="VwAccountRelationship:ReverseRelationTypeId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByReverseRelationType { get; set; }
		[CProperty(Association ="VwContactRelationship:RelationTypeId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByRelationType { get; set; }
		[CProperty(Association ="VwContactRelationship:ReverseRelationTypeId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByReverseRelationType { get; set; }
		#endregion
	}
}
