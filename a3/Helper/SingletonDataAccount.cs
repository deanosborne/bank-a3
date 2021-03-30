using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Helper
{
	[Serializable]
	public class SingletonDataAccount
	{
		private int nextId;
		private static SingletonDataAccount myInstance;

		public static int NextId
		{
			get
			{
				myInstance.nextId++;
				return myInstance.nextId;
			}
		}

		public static SingletonDataAccount getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new SingletonDataAccount();
			}

			return myInstance;
		}

		public static void setInstance(SingletonDataAccount s)
		{
			myInstance = s;
		}

		private SingletonDataAccount() { }
	}
}
