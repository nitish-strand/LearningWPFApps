﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetIsKool.Model
{
	public class Person
    {
		private string fname;

		public string FName
		{
			get { return fname; }
			set { fname = value; }
		}

		private string lname;

		public string LName
		{
			get { return lname; }
			set { lname = value; }
		}

		private string fullname;

		public string FullName
		{
			get 
			{ 
				return fullname = FName +" "+ LName; 
			}
			set 
			{ 
				if(fullname != value)
				fullname = value; 
			}
		}

	}
}
