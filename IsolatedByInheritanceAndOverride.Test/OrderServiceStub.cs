using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsolatedByInheritanceAndOverride.Test
{
	class OrderServiceStub : OrderService
	{
		private List<Order> m_Orders = null;
		private BookDaoBase m_Dao = null;

		public void SetOrders(List<Order> orders)
		{
			this.m_Orders = orders;
		}

		public void SetDao(BookDaoBase dao)
		{
			this.m_Dao = dao;
		}

		protected override List<Order> GetOrders()
		{
			return m_Orders ?? base.GetOrders();
		}

		protected override BookDaoBase GetBookDao()
		{
			return m_Dao ?? base.GetBookDao();
		}
	}
}
