namespace HomeTask2._1
{
    public interface IOrderSource
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}