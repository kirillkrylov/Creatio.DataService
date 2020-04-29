using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwContactRelationship")]
	public class VwContactRelationship : BaseEntity
	{
		#region Values
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private Guid _RelatedAccountId;
		[CProperty(ColumnPath ="RelatedAccountId")]
		public Guid RelatedAccountId
		{
			get{return _RelatedAccountId;}
			set
			{
				_RelatedAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RelatedContactId;
		[CProperty(ColumnPath ="RelatedContactId")]
		public Guid RelatedContactId
		{
			get{return _RelatedContactId;}
			set
			{
				_RelatedContactId = value;
				OnPropertyChanged();
			}
		}
		private string _RelatedObjectName;
		[CProperty(ColumnPath ="RelatedObjectName")]
		public string RelatedObjectName
		{
			get{return _RelatedObjectName;}
			set
			{
				_RelatedObjectName = value;
				OnPropertyChanged();
			}
		}
		private Guid _RelationTypeId;
		[CProperty(ColumnPath ="RelationTypeId")]
		public Guid RelationTypeId
		{
			get{return _RelationTypeId;}
			set
			{
				_RelationTypeId = value;
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
		[CProperty(Navigation ="Account:RelatedAccountId")]
		public Account RelatedAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:RelatedContactId")]
		public Contact RelatedContact { get; set; }
		[CProperty(Navigation ="RelationType:RelationTypeId")]
		public RelationType RelationType { get; set; }
		[CProperty(Navigation ="RelationType:ReverseRelationTypeId")]
		public RelationType ReverseRelationType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
