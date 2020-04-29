using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadIdWithGA")]
	public class LeadIdWithGA : BaseEntity
	{
		#region Values
		private string _CustomerIP;
		[CProperty(ColumnPath ="CustomerIP")]
		public string CustomerIP
		{
			get{return _CustomerIP;}
			set
			{
				_CustomerIP = value;
				OnPropertyChanged();
			}
		}
		private string _GoogleAnalytics;
		[CProperty(ColumnPath ="GoogleAnalytics")]
		public string GoogleAnalytics
		{
			get{return _GoogleAnalytics;}
			set
			{
				_GoogleAnalytics = value;
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
		private string _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public string LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private string _MarketingActivity;
		[CProperty(ColumnPath ="MarketingActivity")]
		public string MarketingActivity
		{
			get{return _MarketingActivity;}
			set
			{
				_MarketingActivity = value;
				OnPropertyChanged();
			}
		}
		private string _Partner;
		[CProperty(ColumnPath ="Partner")]
		public string Partner
		{
			get{return _Partner;}
			set
			{
				_Partner = value;
				OnPropertyChanged();
			}
		}
		private string _UTMCampaign;
		[CProperty(ColumnPath ="UTMCampaign")]
		public string UTMCampaign
		{
			get{return _UTMCampaign;}
			set
			{
				_UTMCampaign = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
