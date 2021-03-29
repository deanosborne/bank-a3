using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.Helper
{
	[Serializable]
	public class SingletonData
	{
		private int nextId;
		private static SingletonData myInstance;

		public static int NextId
		{
			get
			{
				myInstance.nextId++;
				return myInstance.nextId;
			}
		}

		public static SingletonData getInstance()
		{
			if (myInstance == null)
			{
				myInstance = new SingletonData();
			}

			return myInstance;
		}

		public static void setInstance(SingletonData s)
		{
			myInstance = s;
		}

		private SingletonData() { }
	}
}
