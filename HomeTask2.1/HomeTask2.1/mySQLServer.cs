namespace HomeTask2._1
{
    public class mySQLServer : IOrderSource
    {
        public Order Load(int orderId) => null;
        public void Save(Order order){}
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }
}