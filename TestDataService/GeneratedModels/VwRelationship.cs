using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRelationship")]
	public class VwRelationship : BaseEntity
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
		private string _Our;
		[CProperty(ColumnPath ="Our")]
		public string Our
		{
			get{return _Our;}
			set
			{
				_Our = value;
				OnPropertyChanged();
			}
		}
		private string _OutputRelationType;
		[CProperty(ColumnPath ="OutputRelationType")]
		public string OutputRelationType
		{
			get{return _OutputRelationType;}
			set
			{
				_OutputRelationType = value;
				OnPropertyChanged();
			}
		}
		private string _OutputReverseRelationType;
		[CProperty(ColumnPath ="OutputReverseRelationType")]
		public string OutputReverseRelationType
		{
			get{return _OutputReverseRelationType;}
			set
			{
				_OutputReverseRelationType = value;
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
		private string _Related;
		[CProperty(ColumnPath ="Related")]
		public string Related
		{
			get{return _Related;}
			set
			{
				_Related = value;
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
		#endregion

		#region Associations
		#endregion
	}
}
