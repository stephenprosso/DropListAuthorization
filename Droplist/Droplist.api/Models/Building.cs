﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Droplist.api.Models
{
	public class Building
	{
		// Scalar Properties

		public int BuildingId { get; set; }
		public int BuildingNumber { get; set; }
		public string BuildingName { get; set; }
		public string Telephone { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }

		// Navigation properties
		public virtual ICollection<Droplist> Droplists { get; set; }
		public virtual ICollection<Employee> Employees { get; set; }
		public virtual ICollection<Section> Sections { get; set; }
		public virtual ICollection<Product> Products { get; set; }


	}
}