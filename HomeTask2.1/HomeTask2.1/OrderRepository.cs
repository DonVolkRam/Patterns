namespace HomeTask2._1
{
    class OrderRepository
    {
        private IOrderSource source;

        public OrderRepository(IOrderSource source) => this.source = source;
        public void Save(Order order) { source.Save(order); }
        public Order Load(int orderId) { return source.Load(orderId); }
        public void Update(Order order) { source.Update(order); }
        public void Delete(Order order) { source.Delete(order); }
    } 
}
