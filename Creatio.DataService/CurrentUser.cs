using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace Creatio
{
	[JsonObject]
	public class CurrentUser
	{
		public HttpStatusCode Code { get; set; }
		public string ErrorMessage { get; set; }

		[JsonProperty("CURRENT_USER")]
		public ValueDisplayValue User { get; set; }

		[JsonProperty("CURRENT_USER_CULTURE")]
		public ValueDisplayValue Culture { get; set; }

		[JsonProperty("PRIMARY_CULTURE")]
		public ValueDisplayValue PrimaryCulture { get; set; }

		[JsonProperty("PRIMARY_LANGUAGE")]
		public CodeValueDisplayValue PrimaryLanguage { get; set; }

		[JsonProperty("CURRENT_USER_CONTACT")]
		public PrimaryimagevalueValueDisplayValue Contact { get; set; }

		[JsonProperty("CURRENT_USER_TIMEZONE_OFFSET")]
		public int TimeZoneOffset { get; set; }

		[JsonProperty("CURRENT_USER_TIMEZONE_CODE")]
		public string TimezoneCode { get; set; }

		[JsonProperty("CURRENT_USER_ACCOUNT")]
		public ValueDisplayValue Account { get; set; }

		[JsonProperty("CURRENT_WORKSPACE")]
		public ValueDisplayValue Workspace { get; set; }

		[JsonProperty("CURRENT_MAINTAINER")]
		public ValueDisplayValue Maintainer { get; set; }

		[JsonProperty("CURRENT_MONEY_DISPLAY_PRECISION")]
		public int MoneyDisplayPrecision { get; set; }

		[JsonProperty("CUSTOMER")]
		public string Customer { get; set; }

		[JsonProperty("MAX_ENTITY_SCHEMA_NAME_LENGTH")]
		public int MaxEntitySchemaNameLength { get; set; }
	}

	[JsonObject]
	public class ValueDisplayValue
	{
		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("displayValue")]
		public string DisplayValue { get; set; }
	}

	[JsonObject]
	public class CodeValueDisplayValue : ValueDisplayValue
	{
		[JsonProperty("code")]
		public string Code { get; set; }
	}

	[JsonObject]
	public class PrimaryimagevalueValueDisplayValue : ValueDisplayValue
	{
		[JsonProperty("primaryImageValue")]
		public string PrimaryImageValue { get; set; }
	}
}
