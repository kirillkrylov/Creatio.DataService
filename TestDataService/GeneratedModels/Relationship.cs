using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Relationship")]
	public class Relationship : BaseEntity
	{
		#region Values
		private Guid _AccountAId;
		[CProperty(ColumnPath ="AccountAId")]
		public Guid AccountAId
		{
			get{return _AccountAId;}
			set
			{
				_AccountAId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountBId;
		[CProperty(ColumnPath ="AccountBId")]
		public Guid AccountBId
		{
			get{return _AccountBId;}
			set
			{
				_AccountBId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _ContactAId;
		[CProperty(ColumnPath ="ContactAId")]
		public Guid ContactAId
		{
			get{return _ContactAId;}
			set
			{
				_ContactAId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactBId;
		[CProperty(ColumnPath ="ContactBId")]
		public Guid ContactBId
		{
			get{return _ContactBId;}
			set
			{
				_ContactBId = value;
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
		[CProperty(Navigation ="Account:AccountAId")]
		public Account AccountA { get; set; }
		[CProperty(Navigation ="Account:AccountBId")]
		public Account AccountB { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactAId")]
		public Contact ContactA { get; set; }
		[CProperty(Navigation ="Contact:ContactBId")]
		public Contact ContactB { get; set; }
		[CProperty(Navigation ="RelationType:RelationTypeId")]
		public RelationType RelationType { get; set; }
		[CProperty(Navigation ="RelationType:ReverseRelationTypeId")]
		public RelationType ReverseRelationType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
