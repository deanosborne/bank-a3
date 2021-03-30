using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Helper
{
	[Serializable]
	public class SingletonDataTransaction
	{
		private int nextId;
		private static SingletonDataTransaction myInstance;

		public static int NextId
		{
			get
			{
				myInstance.nextId++;
				return myInstance.nextId;
			}
		}

		public static SingletonDataTransaction getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new SingletonDataTransaction();
			}

			return myInstance;
		}

		public static void setInstance(SingletonDataTransaction s)
		{
			myInstance = s;
		}

		private SingletonDataTransaction() { }
	}
}
