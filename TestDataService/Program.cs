using Avalara.AvaTax.RestClient;
using Creatio.DataService;
using Creatio.DataService.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TestDataService.Properties;
using static Creatio.DataService.Enums;
using DocumentType = Avalara.AvaTax.RestClient.DocumentType;

namespace TestDataService
{
	public sealed class Program
	{
		public static async Task Main(string[] args)
		{
			Utils.SetCredentials(Resources.UserName, Resources.Password, Resources.Domain);
			Utils utils = Utils.Instance;

			try
			{
				await utils.LoginAsync();
			}
			catch (CreationException ex)
			{
				Console.WriteLine(ex.Message); 
			}
			
			if (utils.IsLoginSuccess)
			{
				utils.WebSocketMessageReceived += WebSocketMessageReceived;
				utils.Disconnected += OnDisconnected;

				string ExternalUrl = @"https://www.terrasoft.ru/page/osnovy-marketing-creatio-dlya-marketologov";

				var contact = new Contact() { Id = Guid.Parse("d4f14f0c-f881-46f5-aeb8-9f3129e48e7f") };

				await contact.ExpandValuesAsync();
				await contact.ExpandNavAsync(true, nameof(contact.City));

				Console.WriteLine(contact.City.Name);



				//Console.WriteLine("sending request...");
				//List<Lead> leads = await utils.Select<Lead>(LeadsByExternalUrl(ExternalUrl));
							
				//Console.WriteLine("*** Results ***");
				//foreach(Lead lead in leads)
				//{
				//    await lead.ExpandNavAsync(false, nameof(lead.QualifyStatus));
				//    Console.WriteLine($"Contact: {lead.Contact} Email: {lead.Email} Status: {lead.QualifyStatus.Name}");
				//}
			 



				//Guid.TryParse(utils.CurrentUser.Contact.Value, out Guid contactId);
				//Contact contact = new Contact() { Id = contactId };

				//await contact.ExpandValuesAsync();
				//Console.WriteLine(contact.Name);
				//await contact.ExpandNavAsync(true, nameof(contact.Account), nameof(contact.Photo));

				//await contact.ExpandAssociationsAsync(true, nameof(contact.ContactCommunicationByContact));
				//Console.WriteLine("I can be best reach at");
				//foreach(var comOpt in contact.ContactCommunicationByContact)
				//{
				//    await comOpt.ExpandNavAsync(true, nameof(comOpt.CommunicationType));
				//    Console.WriteLine($"\t{comOpt.CommunicationType.Name}: {comOpt.Number}");
				//}

				//List<Invoice> Invoices = await utils.Select<Invoice>(CreateCustomFilter(new DateTime(2020,1,1), new DateTime(2020,8,5)),false);
				//Console.WriteLine("Total Invoices: "+Invoices.Count);

				//Parallel.ForEach(Invoices, async invoice =>
				//{
				//    await invoice.ExpandNavAsync(false, nameof(invoice.Account));
				//});

				//foreach(Invoice invoice in Invoices)
				//{
				//    Console.WriteLine(invoice.Number + " " + invoice.AccountId);
				//}





				//Console.WriteLine(Invoices.Count);
				//foreach(Invoice invoice in Invoices)
				//{
				//    string msg = $"Invoice Number: {invoice.Number} Account Name: {invoice.Account?.Name}";
				//    Console.WriteLine();
				//}


				//Contact newFriend = new Contact()
				//{

				//    Name = "My new friend2",
				//    Email = "newfriend2@creatio.com",
				//    AccountId = contact.AccountId
				//};
				//var insertResult = await utils.InsertAsync(newFriend);

				//var updateResult = await newFriend.UpdateAsync();
				//Console.WriteLine(updateResult.Result.RowsAffected);


				//Account account = new Account() { Id = Guid.Parse("9086535B-53D3-4824-94DB-BDE98B009C79") };
				//await account.ExpandValuesAsync(true);

				//await account.ExpandNavAsync(true, nameof(Account.Owner));

				//Console.WriteLine($"Name:{account.Owner.Name}\t\tNameEng:{account.Owner.NameEng}");
				//Console.ReadLine();
				//var a = "";


				//await contact.Photo.ExpandValuesAsync();

				//string photoDataBase64 = (await utils.GetImageAsync(contact.Photo.Id.ToString()).ConfigureAwait(false)).ResultString;
				//byte[] imageBytes = Convert.FromBase64String(photoDataBase64);
				//FileStream fs = new FileStream(@"C:\"+contact.Photo.Name, FileMode.OpenOrCreate);
				//await fs.WriteAsync(imageBytes);


				//var a = "";
				//Contact contact = new Contact() { Id = Guid.Parse(utils.CurrentUser.Contact.Value) };
				//contact.Phone = "2134";
				////await contact.ExpandValuesAsync();

				//string filePath = @"C:\Users\k.krylov\Pictures\Logos\63b3c7e2-25ee-4c08-9b91-d3e2416ee90d.gif";
				//FileInfo fileInfo = new FileInfo(filePath);
				//var f = await System.IO.File.ReadAllBytesAsync(fileInfo.FullName);

				////Upload Notes and Appachments
				////var r = await utils.UploadFileAsync(f, $"image/{fileInfo.Extension}", 
				////fileInfo.Name, nameof(Contact), contact.Id.ToString(), "ContactFile", "Data");

				////var rr = await utils.UploadFileAsync(f, $"image/{fileInfo.Extension}", fileInfo.Name, null, null, null, null);

				////contact.PhotoId = rr.Result.Id;
				//await contact.UpdateAsync();

				//Console.WriteLine(rr.Result.Id.ToString());
			}
			Console.ReadLine();
			await utils.LogoutAsync();
			utils.Dispose();
		}
		private static Filters LeadsByExternalUrl(string ExternalUrl)
		{
			var CustomFilter = new Filters()
			{
				// Filter type is group.
				FilterType = FilterType.FilterGroup,
				// Filters collection.
				LogicalOperation = LogicalOperationStrict.And,
				Items = new Dictionary<string, Filter>()
				{
					{
						"ExternalUrl", new Filter
						{
							FilterType = FilterType.CompareFilter,
							ComparisonType = FilterComparisonType.Equal,
							LeftExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
								ColumnPath = "WebForm.ExternalURL"
							},
							RightExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.Parameter,
								Parameter = new Parameter()
								{
									DataValueType = DataValueType.Text,
									Value = ExternalUrl
								}
							}
						}
					}
				}
			};
			return CustomFilter;
		}
		private static Filters CreateCustomFilter(DateTime startDate, DateTime endDate)
		{
			var CustomFilter = new Filters()
			{
				// Filter type is group.
				FilterType = FilterType.FilterGroup,
				// Filters collection.
				LogicalOperation = LogicalOperationStrict.And,
				Items = new Dictionary<string, Filter>()
				{
					{
						"GreaterThanOrEqualToStartDate", new Filter
						{
							FilterType = FilterType.CompareFilter,
							ComparisonType = FilterComparisonType.GreaterOrEqual,
							LeftExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
								ColumnPath = "StartDate"
							},
							RightExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.Parameter,
								Parameter = new Parameter()
								{
									DataValueType = DataValueType.Date,
									Value = String.Format("'{0}'", startDate)
								}
							}
						}
					},
					{
						"LessThanOrEqualToStartDate", new Filter
						{
							FilterType = FilterType.CompareFilter,
							ComparisonType = FilterComparisonType.LessOrEqual,
							LeftExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
								ColumnPath = "StartDate"
							},
							RightExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.Parameter,
								Parameter = new Parameter()
								{
									DataValueType = DataValueType.Date,
									Value = String.Format("'{0}'", endDate)
								}
							}
						}
					},
					{
						"SupplierBillingInfo", new Filter
						{
							FilterType = FilterType.CompareFilter,
							ComparisonType = FilterComparisonType.Equal,
							LeftExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
								ColumnPath = "SupplierBillingInfo"
							},
							RightExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.Parameter,
								Parameter = new Parameter()
								{
									DataValueType = DataValueType.Guid,
									Value = "c26c88be-b380-4566-b65e-f738ccdeec19"
								}
							}
						}
					},
					{
						//CustomerBillingInfoCountry = USA
						"CustomerBillingInfoCountry", new Filter
						{
							FilterType = FilterType.CompareFilter,
							ComparisonType = FilterComparisonType.Equal,
							LeftExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
								ColumnPath = "CustomerBillingInfo.Country"
							},
							RightExpression = new BaseExpression()
							{
								ExpressionType = EntitySchemaQueryExpressionType.Parameter,
								Parameter = new Parameter()
								{
									DataValueType = DataValueType.Guid,
									Value = "2E08EE8D-133E-4968-B6E8-E3913ECFA69E"
								}
							}
						}
					},
					{
						"InvoiceStatus", new Filter
						{
							FilterType = FilterType.FilterGroup,
							LogicalOperation = LogicalOperationStrict.Or,
							Items = new Dictionary<string, Filter>()
							{
								{
									"InvoiceFullyPaid",new Filter
									{
										FilterType = FilterType.CompareFilter,
										ComparisonType = FilterComparisonType.Equal,
										LeftExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
											ColumnPath = "PaymentStatus"
										},
										RightExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.Parameter,
											Parameter = new Parameter()
											{
												DataValueType = DataValueType.Text,
												Value = "698D39FD-52E6-DF11-971B-001D60E938C6"
											}
										}
									}
								},
								{
									"InvoicePartiallyPaid",new Filter
									{
										FilterType = FilterType.CompareFilter,
										ComparisonType = FilterComparisonType.Equal,
										LeftExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
											ColumnPath = "PaymentStatus"
										},
										RightExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.Parameter,
											Parameter = new Parameter()
											{
												DataValueType = DataValueType.Text,
												Value = "03794BF5-52E6-DF11-971B-001D60E938C6"
											}
										}
									}
								},
								{
									"InvoiceAwaitingPayment",new Filter
									{
										FilterType = FilterType.CompareFilter,
										ComparisonType = FilterComparisonType.Equal,
										LeftExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
											ColumnPath = "PaymentStatus"
										},
										RightExpression = new BaseExpression()
										{
											ExpressionType = EntitySchemaQueryExpressionType.Parameter,
											Parameter = new Parameter()
											{
												DataValueType = DataValueType.Text,
												Value = "36319D13-98E6-DF11-971B-001D60E938C6"
											}
										}
									}
								}
							}
						}
					}
				}
			};
			return CustomFilter;
		}
		private static void WebSocketMessageReceived(object sender, WebSocketMessageReceivedEventArgs e)
		{
			//Console.WriteLine();
			//Console.ForegroundColor = ConsoleColor.Green;
			//Console.WriteLine($"You've got message: {e.MessageId}\n{e.MessageHeader.Sender}\n{ e.MessageBody}");
			//Console.ResetColor();
		}
		private static void OnDisconnected(object sender, DisconnectedEventArgs e)
		{
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("*************************");
			Console.WriteLine($"Disconnected from Creatio due to ErrorCode:{e.ErrorCode}:\n\t{e.Message}");
			Console.ResetColor();
		}
		private static async Task InvoiceById(Guid invoiceId)
		{
			Invoice invoice = new Invoice() { Id = invoiceId };
			await invoice.ExpandValuesAsync();
			await invoice.ExpandNavAsync(false, nameof(invoice.CustomerBillingInfo), nameof(invoice.SupplierBillingInfo));
			
			AccountBillingInfo customerBillingInfo = invoice.CustomerBillingInfo;
			await customerBillingInfo.ExpandNavAsync(false, nameof(customerBillingInfo.Country), nameof(customerBillingInfo.Region), nameof(customerBillingInfo.City));

			string ZipCode = await ValidateZipCodeAsync(invoice.CustomerBillingInfo.Name, "", invoice.CustomerBillingInfo.Street, invoice.CustomerBillingInfo.City.Name,
				invoice.CustomerBillingInfo.Region.Name, invoice.CustomerBillingInfo.ZipCode);

			string cAddress = $"Customer: {invoice.CustomerBillingInfo.Name}" +
				$"{Environment.NewLine}\tCustomer Billing Info Id: {invoice.CustomerBillingInfoId.ToString()}" +
				$"{Environment.NewLine}\t{invoice.CustomerBillingInfo.Street}" +
				$"{Environment.NewLine}\t{invoice.CustomerBillingInfo.City.Name}, {invoice.CustomerBillingInfo.Region.Name}" +
				$"{Environment.NewLine}\t{invoice.CustomerBillingInfo.Country.Name}, {ZipCode}";
			Console.WriteLine(cAddress);
			Console.WriteLine(Environment.NewLine);

			AccountBillingInfo supplierBillingInfo = invoice.SupplierBillingInfo;
			await supplierBillingInfo.ExpandNavAsync(false, nameof(supplierBillingInfo.Country), nameof(supplierBillingInfo.Region), nameof(supplierBillingInfo.City));
			string sAddress = $"Supplier: {invoice.SupplierBillingInfo.Name}" +
				$"{Environment.NewLine}\tSupplier Billing Info Id: {invoice.SupplierBillingInfoId.ToString()}" +
				$"{Environment.NewLine}\t{invoice.SupplierBillingInfo.Street}" +
				$"{Environment.NewLine}\t{invoice.SupplierBillingInfo.City.Name}, {invoice.SupplierBillingInfo.Region.Name}" +
				$"{Environment.NewLine}\t{invoice.SupplierBillingInfo.Country.Name}, {invoice.SupplierBillingInfo.ZipCode}";
			Console.WriteLine(sAddress);

			ParametersHeader parameters = new ParametersHeader()
			{
				to_street = invoice.CustomerBillingInfo.Street.Trim(),
				to_city = invoice.CustomerBillingInfo.City.Name.Trim(),
				to_state = invoice.CustomerBillingInfo.Region.Name.Trim(),
				to_zip = ZipCode.Trim(),
				to_country = "US",
				shipping = "0",
				customer_code_string = invoice.CustomerBillingInfo.Name.Trim(),
				PoNumber = invoice.Number.Trim(),
				InvoiceDate = invoice.StartDate,
				currencyCode = "USD"
			};

			await invoice.ExpandAssociationsAsync(false, nameof(invoice.InvoiceProductByInvoice));
			ICollection<InvoiceProduct> invoiceProducts = invoice.InvoiceProductByInvoice;

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("--- INVOICE LINES ---");

			int i = 1;
			foreach (InvoiceProduct invoiceProduct in invoiceProducts)
			{
				await invoiceProduct.ExpandNavAsync(false, nameof(invoiceProduct.Product));

				Product product = invoiceProduct.Product;
				await product.ExpandNavAsync(false, nameof(product.Type), nameof(product.Category), nameof(product.DeliveryType), nameof(product.Kind), nameof(product.DeploymentType));

				string line = $"{Environment.NewLine}Line #:{i.ToString("#")}" +
					$"{Environment.NewLine}{invoiceProduct.Product.NameENU}\tQty: {invoiceProduct.Quantity.ToString()}, Price: {invoiceProduct.Price.ToString("C2")}, Total: {invoiceProduct.PrimaryAmount.ToString("C2")}" +
					$"{Environment.NewLine}\tCategory:\t{invoiceProduct.Product.Category.Name} " +
					$"{Environment.NewLine}\tDeployment:\t{invoiceProduct.Product.Type.Name}" +
					$"{Environment.NewLine}\tKind:\t\t{invoiceProduct.Product.Kind.Name}" +
					$"{Environment.NewLine}\tDeployment:\t{invoiceProduct.Product.DeploymentType.Name}" +
					$"{Environment.NewLine}\tDelivery:\t{invoiceProduct.Product.DeliveryType.Name} ";

				Console.WriteLine(line);
				Console.ForegroundColor = ConsoleColor.Green;

				string avaCode = GetAvalaraTaxCode(invoiceProduct.Product.Category.Name, invoiceProduct.Product.DeploymentType.Name,
					invoiceProduct.Product.Kind.Name, invoiceProduct.Product.Type.Name, invoiceProduct.Product.Name);

				string taxCodes = $"\tTaxJar:\t{invoiceProduct.Product.TaxCode.ToString().Trim()}" +
					$"{Environment.NewLine}\tAvaTax:\t{avaCode.Trim()}";

				ParameterLine parameterLine = new ParameterLine
				{
					quantity = "1",
					unit_price = invoiceProduct.PrimaryAmount.ToString(),
					avaTaxCode = avaCode,
					id = invoiceProduct.Product.Id.ToString(),
					description = invoiceProduct.Product.NameENU
				};
				parameters.line_items.Add(parameterLine);

				Console.WriteLine(taxCodes);
				Console.ResetColor();
				i++;
			}
			await CalculateSingleAvalaraTaxAsync(parameters);
		}
		public static async Task CalculateSingleAvalaraTaxAsync(ParametersHeader parameters)
		{
			const string licenseKey = "3C154FC03B81D3D5";
			const int accountId = 2000160773;
			const string companyCode = "DEFAULT";

			AvaTaxClient client = new AvaTaxClient("MyConsoleApp", "1.0", Environment.MachineName, AvaTaxEnvironment.Production)
				   .WithSecurity(accountId, licenseKey);

			TransactionBuilder t1 = new TransactionBuilder(client, companyCode, DocumentType.SalesOrder, parameters.customer_code_string)
			  .WithAddress(TransactionAddressType.SingleLocation, parameters.to_street, null, null, parameters.to_city,
			  parameters.to_state.ToString(), parameters.to_zip, parameters.to_country)
			  .WithDate(parameters.InvoiceDate)
			  .WithReportingLocationCode("DEFAULT")
			  .WithPurchaseOrderNumber(parameters.PoNumber);
			
				

			int i = 1;
			foreach (ParameterLine lineItem in parameters.line_items) {
				
				decimal qty = decimal.Zero;
				decimal.TryParse(lineItem.quantity, out qty);

				decimal unit_price = decimal.Zero;
				decimal.TryParse(lineItem.unit_price, out unit_price);

				string avaTaxCode = lineItem.avaTaxCode;
				string id = lineItem.id;

				t1.WithLine(unit_price, qty, avaTaxCode, lineItem.description, id, null, i.ToString());
				
				i++;
			}

			try
			{
				TransactionModel tm = await t1.CreateAsync();
				if (tm.lines != null)
				{
					foreach (TransactionLineModel line in tm.lines)
					{
						Guid.TryParse(line.itemCode, out Guid Id);

						var a = parameters.line_items.Find(l => l.id == Id.ToString());
						a.taxAmount = line.taxCalculated ?? 0;
						Console.WriteLine(a.taxAmount);
					}
				}
			}
			catch (AvaTaxError ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.error);
				Console.ResetColor();
			}
		}
		private static async Task<string> ValidateZipCodeAsync(string Name, string Address1, string Address2, string City, string State, string Zip) 
		{

			USPS.ZipCodeLookupRequest request = new USPS.ZipCodeLookupRequest()
			{
				Name = Name,
				Address1 = Address1.Trim(),
				Address2 = Address2.Trim(),
				City = City.Trim(),
				State = State.Trim()
			};


			USPS.UspsAddress validatedAddress = await USPS.ZipCodeLookupAsync(request);

			string ZipCode = "";
			if (!string.IsNullOrEmpty(validatedAddress.Zip5) && !string.IsNullOrEmpty(validatedAddress.Zip4))
			{
				ZipCode = String.Format("{0}-{1}", validatedAddress.Zip5, validatedAddress.Zip4);
			}
			else
			{
				ZipCode = (!string.IsNullOrEmpty(validatedAddress.Zip5)) ? validatedAddress.Zip5 : Zip;
			}


			return ZipCode;
		}
		private static async void ContactById(string ContactId) {
			Contact currentUser = new Contact() { Id = Guid.Parse(ContactId) };
			

			//currentUser.ExpandValues();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine();
			Console.WriteLine("-------------- CURRENT USER SelectById --------------");
			Console.WriteLine($"Id:\t\t {currentUser.Id.ToString().Trim()}");
			Console.WriteLine($"Name:\t\t {currentUser.Name ?? currentUser.NameEng}");
			Console.WriteLine($"Email:\t\t {currentUser.Email}");
			Console.WriteLine($"CreatedOn:\t {currentUser.CreatedOn.ToString("dd-MMM-yyyy").Trim()}");
			Console.ResetColor();
			Console.WriteLine();

			await currentUser.ExpandAssociationsAsync(false, nameof(currentUser.ContactAddressByContact));

			foreach (ContactAddress address in currentUser.ContactAddressByContact) 
			{
				Console.WriteLine(address.Address);
			}
			
		}
		public static string GetAvalaraTaxCode(string category = "", string deployment = "", string kind = "", string type = "", string name = "")
		{

			if (name.Contains("Annual membership fee package")) return "ON010100";

			if (category == "Products" && deployment.ToUpper() == "ON-SITE") return "SW053000";
			if (category == "Products" && deployment.ToUpper() == "CLOUD") return "SW054000";

			if (category == "Services" && type.ToUpper() == "SUPPORT") return "SC130101";
			if (category == "Services" && type.ToUpper() == "CLOUD") return "SC130101";

			if (category == "Services" && type == "Training" && kind == "Academy") return "ST087634";
			if (category == "Services" && type == "Training" && kind == "Events") return "OL010000";

			if (category == "Services" && type == "Third-party services") return "SC130101";
			if (category == "Services" && type == "Implementation") return "SW052010";
			if (category == "Services" && type == "Hours of consultation") return "SW052010";

			return "P0000000";
		}
		private static async Task AdHocQuery() {
			Console.Write("Enter Email to Search: ");
			Console.ForegroundColor = ConsoleColor.Green;
			string email = Console.ReadLine().Trim();
			Console.ResetColor();
			
			if ((await SearchByEmail(email)).Count == 0) 
			{
				await SearchComOptEmail(email);
			}
			await AdHocQuery();
		}
		/*
		private static async Task<int> SearchByEmail(string email) {
			
			Utils utils = Utils.Instance;
			SelectQuery select = BuildContactQuery(nameof(Contact), nameof(Contact.Email), email, nameof(Contact.Name));
			string jsonRequest = JsonConvert.SerializeObject(select);
			RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);
			DataTable dt = utils.ConvertResponseToDataTable(result.ResultString);

			if (dt.Rows.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("No Record Found");
				Console.ResetColor();
				return 0;
			}
			else
			{
				Console.WriteLine("----------- Search Email in Contact -----------");
				foreach (DataRow dr in dt.Rows)
				{
					foreach (DataColumn dc in dt.Columns)
					{
						Console.WriteLine($"{dc.ColumnName}: {dr[dc.ColumnName]}");
					}
				}
				return dt.Rows.Count;
			}
		}
		private static async Task<int> SearchComOptEmail(string email)
		{
			Utils utils = Utils.Instance;
			SelectQuery select = BuildContactQuery(nameof(ContactCommunication), nameof(ContactCommunication.Number), email, nameof(ContactCommunication.Contact));
			string jsonRequest = JsonConvert.SerializeObject(select);
			RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);
			DataTable dt = utils.ConvertResponseToDataTable(result.ResultString);

			if (dt.Rows.Count == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("No Record Found");
				Console.ResetColor();
				return 0;
			}
			else
			{
				Console.WriteLine("----------- Search Number in ContactCommunication -----------");
				foreach (DataRow dr in dt.Rows)
				{
					foreach (DataColumn dc in dt.Columns)
					{
						Console.WriteLine($"{dc.ColumnName}: {dr[dc.ColumnName]}");
					}
				}
				return dt.Rows.Count;
			}

		}
		*/
		private static async Task<List<Guid>> SearchByEmail(string email)
		{
			Utils utils = Utils.Instance;
			SelectQuery select = BuildContactQuery("Contact", "Email", email, "Name");
			string jsonRequest = JsonConvert.SerializeObject(select);
			RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);

			List<Guid> results = new List<Guid>();
			DataTable dt = utils.ConvertResponseToDataTable(result.ResultString);

			if (dt.Rows.Count != 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					if (Guid.TryParse(dr["Id"].ToString(), out Guid recordId))
					{
						results.Add(recordId);
					}
				}
			}
			return results;
		}
		private static async Task<List<Guid>> SearchComOptEmail(string email)
		{
			Utils utils = Utils.Instance;
			SelectQuery select = BuildContactQuery("ContactCommunication", "Number", email, "Contact");
			string jsonRequest = JsonConvert.SerializeObject(select);
			RequestResponse result = await utils.GetResponseAsync(jsonRequest, ActionEnum.SELECT).ConfigureAwait(false);
			DataTable dt = utils.ConvertResponseToDataTable(result.ResultString);

			List<Guid> results = new List<Guid>();
			if (dt.Rows.Count != 0)
			{
				foreach (DataRow dr in dt.Rows)
				{
					if (Guid.TryParse(dr["Contact"].ToString(), out Guid recordId))
					{
						results.Add(recordId);
					}
				}

			}
			return results;
		}
		private static SelectQuery BuildContactQuery(string RootSchemaName, string LookupColumn, object LookupValue, string ResultColumn) {

			DataValueType dtv = DataValueType.Text;
			
			switch (LookupValue.GetType().Name) {
				case nameof(String):
					dtv = DataValueType.Text;
					break;
				case nameof(Int16):
				case nameof(Int32):
				case nameof(Int64):
					dtv = DataValueType.Integer;
					break;
				case nameof(Decimal):
					dtv = DataValueType.Float;
					break;
				case nameof(Guid):
					dtv = DataValueType.Guid;
					break;
				case nameof(DateTime):
					dtv = DataValueType.DateTime;
					break;
				default:
					dtv = DataValueType.Text;
					break;
			};
			
			SelectQuery contactQuery = new SelectQuery()
			{
				RootSchemaName = RootSchemaName,
				RowCount = 10,
				RowsOffset = -1,
				QueryKind = Enums.QueryKind.General,
				QuerySource = Enums.QuerySource.Filter,
				UseLocalization = true,
				QueryOptimize = true,
				IgnoreDisplayValues = true,
				Columns = new SelectQueryColumns()
				{
					Items = new Dictionary<string, SelectQueryColumn>()
					{
						{
							"Id", new SelectQueryColumn()
							{
								Expression = new ColumnExpression()
								{
									ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
									ColumnPath = "Id"
								}
							}
						},
						{
							ResultColumn, new SelectQueryColumn()
							{
								Expression = new ColumnExpression()
								{
									ExpressionType = Enums.EntitySchemaQueryExpressionType.SchemaColumn,
									ColumnPath = ResultColumn
								}
							}
						}
					}
				},
				Filters = new Filters()
				{
					// Filter type is group.
					FilterType = FilterType.FilterGroup,
					// Filters collection.
					LogicalOperation = LogicalOperationStrict.And,
					Items = new Dictionary<string, Filter>()
					{
						{
							"LookupFilter", new Filter
							{
								FilterType = FilterType.CompareFilter,
								ComparisonType = FilterComparisonType.Equal,
								LeftExpression = new BaseExpression()
								{
									ExpressionType = EntitySchemaQueryExpressionType.SchemaColumn,
									ColumnPath = LookupColumn
								},
								RightExpression = new BaseExpression()
								{
									ExpressionType = EntitySchemaQueryExpressionType.Parameter,
									Parameter = new Parameter()
									{
										DataValueType = dtv,
										Value = LookupValue
									}
								}
							}
						}
					}
				}

			};
			return contactQuery;
		}
		
	}
}
