using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChannel")]
	public class BeesenderChannel : BaseEntity
	{
		#region Values
		private string _ClientId;
		[CProperty(ColumnPath ="ClientId")]
		public string ClientId
		{
			get{return _ClientId;}
			set
			{
				_ClientId = value;
				OnPropertyChanged();
			}
		}
		private string _ClientSecret;
		[CProperty(ColumnPath ="ClientSecret")]
		public string ClientSecret
		{
			get{return _ClientSecret;}
			set
			{
				_ClientSecret = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfigurationId;
		[CProperty(ColumnPath ="ConfigurationId")]
		public Guid ConfigurationId
		{
			get{return _ConfigurationId;}
			set
			{
				_ConfigurationId = value;
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
		private string _InternalId;
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId
		{
			get{return _InternalId;}
			set
			{
				_InternalId = value;
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
		private string _SiteCode;
		[CProperty(ColumnPath ="SiteCode")]
		public string SiteCode
		{
			get{return _SiteCode;}
			set
			{
				_SiteCode = value;
				OnPropertyChanged();
			}
		}
		private string _Token;
		[CProperty(ColumnPath ="Token")]
		public string Token
		{
			get{return _Token;}
			set
			{
				_Token = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Weight;
		[CProperty(ColumnPath ="Weight")]
		public decimal Weight
		{
			get{return _Weight;}
			set
			{
				_Weight = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChannelType:TypeId")]
		public BeesenderChannelType Type { get; set; }
		[CProperty(Navigation ="BeesenderChatConfiguration:ConfigurationId")]
		public BeesenderChatConfiguration Configuration { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChat:ChannelId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByChannel { get; set; }
		[CProperty(Association ="BeesenderOperatorChannel:ChannelId")]
		public virtual ICollection<BeesenderOperatorChannel> BeesenderOperatorChannelByChannel { get; set; }
		#endregion
	}
}
