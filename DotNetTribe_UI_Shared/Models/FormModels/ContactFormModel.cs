using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetTribe_UI_Shared.Models.FormModels
{
	public class ContactFormModel
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public string? Subject { get; set; }
		public string? Message { get; set; }
		
	}
}