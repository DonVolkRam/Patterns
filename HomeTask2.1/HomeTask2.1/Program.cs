using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderRepository orderRepository = new OrderRepository(new APIOrder());
            orderRepository.Load(1);
        }
    }
}
