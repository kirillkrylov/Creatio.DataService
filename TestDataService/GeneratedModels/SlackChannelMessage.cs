using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SlackChannelMessage")]
	public class SlackChannelMessage : BaseEntity
	{
		#region Values
		private Guid _ChannelId;
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId
		{
			get{return _ChannelId;}
			set
			{
				_ChannelId = value;
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
		private DateTime _MessageDateTime;
		[CProperty(ColumnPath ="MessageDateTime")]
		public DateTime MessageDateTime
		{
			get{return _MessageDateTime;}
			set
			{
				_MessageDateTime = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private string _SubType;
		[CProperty(ColumnPath ="SubType")]
		public string SubType
		{
			get{return _SubType;}
			set
			{
				_SubType = value;
				OnPropertyChanged();
			}
		}
		private string _Text;
		[CProperty(ColumnPath ="Text")]
		public string Text
		{
			get{return _Text;}
			set
			{
				_Text = value;
				OnPropertyChanged();
			}
		}
		private string _Timestamp;
		[CProperty(ColumnPath ="Timestamp")]
		public string Timestamp
		{
			get{return _Timestamp;}
			set
			{
				_Timestamp = value;
				OnPropertyChanged();
			}
		}
		private string _Type;
		[CProperty(ColumnPath ="Type")]
		public string Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
				OnPropertyChanged();
			}
		}
		private Guid _UserId;
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId
		{
			get{return _UserId;}
			set
			{
				_UserId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SlackChannel:ChannelId")]
		public SlackChannel Channel { get; set; }
		[CProperty(Navigation ="SlackChannelMessage:ParentId")]
		public SlackChannelMessage Parent { get; set; }
		[CProperty(Navigation ="SlackUser:UserId")]
		public SlackUser User { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SlackChannelMessage:ParentId")]
		public virtual ICollection<SlackChannelMessage> SlackChannelMessageByParent { get; set; }
		#endregion
	}
}
