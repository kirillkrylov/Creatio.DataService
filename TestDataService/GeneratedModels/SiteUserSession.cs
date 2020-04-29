using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteUserSession")]
	public class SiteUserSession : BaseEntity
	{
		#region Values
		private string _ClientIP;
		[CProperty(ColumnPath ="ClientIP")]
		public string ClientIP
		{
			get{return _ClientIP;}
			set
			{
				_ClientIP = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
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
		private DateTime _SessionEndDate;
		[CProperty(ColumnPath ="SessionEndDate")]
		public DateTime SessionEndDate
		{
			get{return _SessionEndDate;}
			set
			{
				_SessionEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SessionStartDate;
		[CProperty(ColumnPath ="SessionStartDate")]
		public DateTime SessionStartDate
		{
			get{return _SessionStartDate;}
			set
			{
				_SessionStartDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
