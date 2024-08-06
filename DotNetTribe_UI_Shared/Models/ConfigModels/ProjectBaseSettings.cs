using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTribe_UI_Shared.Models.ConfigModels
{
	public class ProjectBaseSettings
	{
		public required string BaseUrl { get; set; }
		public required string JobPostingEndpoint { get; set; }
		public required string AllBlogsEndpoint { get; set; }
		public required string ReadABlogEndpoint { get; set; }
		public required string GetAllResourcesEndpoint { get; set; }
	}
}
