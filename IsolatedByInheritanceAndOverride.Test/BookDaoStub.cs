using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsolatedByInheritanceAndOverride.Test
{
	class BookDaoStub : BookDao
	{
		public int CallCount;

		protected internal override void Insert(Order order)
		{
			if (order.Type == "Book")
				CallCount++;
		}
	}
}
