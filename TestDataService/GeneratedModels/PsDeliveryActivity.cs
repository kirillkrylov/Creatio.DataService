using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsDeliveryActivity")]
	public class PsDeliveryActivity : BaseEntity
	{
		#region Values
		private Guid _ActivityId;
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId
		{
			get{return _ActivityId;}
			set
			{
				_ActivityId = value;
				OnPropertyChanged();
			}
		}
		private string _AddInVersion;
		[CProperty(ColumnPath ="AddInVersion")]
		public string AddInVersion
		{
			get{return _AddInVersion;}
			set
			{
				_AddInVersion = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
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
		private string _JiraComponent;
		[CProperty(ColumnPath ="JiraComponent")]
		public string JiraComponent
		{
			get{return _JiraComponent;}
			set
			{
				_JiraComponent = value;
				OnPropertyChanged();
			}
		}
		private string _JiraEpic;
		[CProperty(ColumnPath ="JiraEpic")]
		public string JiraEpic
		{
			get{return _JiraEpic;}
			set
			{
				_JiraEpic = value;
				OnPropertyChanged();
			}
		}
		private string _JiraEpicName;
		[CProperty(ColumnPath ="JiraEpicName")]
		public string JiraEpicName
		{
			get{return _JiraEpicName;}
			set
			{
				_JiraEpicName = value;
				OnPropertyChanged();
			}
		}
		private string _JiraIncidentNumber;
		[CProperty(ColumnPath ="JiraIncidentNumber")]
		public string JiraIncidentNumber
		{
			get{return _JiraIncidentNumber;}
			set
			{
				_JiraIncidentNumber = value;
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
		private Guid _PsDeliveryId;
		[CProperty(ColumnPath ="PsDeliveryId")]
		public Guid PsDeliveryId
		{
			get{return _PsDeliveryId;}
			set
			{
				_PsDeliveryId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PsDelivery:PsDeliveryId")]
		public PsDelivery PsDelivery { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
