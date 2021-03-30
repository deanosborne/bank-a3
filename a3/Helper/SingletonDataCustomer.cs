using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Helper
{
	[Serializable]
	public class SingletonDataCustomer
	{
		private int nextId;
		private static SingletonDataCustomer myInstance;

		public static int NextId
		{
			get
			{
				myInstance.nextId++;
				return myInstance.nextId;
			}
		}

		public static SingletonDataCustomer getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new SingletonDataCustomer();
			}

			return myInstance;
		}

		public static void setInstance(SingletonDataCustomer s)
		{
			myInstance = s;
		}

		private SingletonDataCustomer() { }
	}
}
