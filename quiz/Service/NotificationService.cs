namespace quiz.Services
{
    public class NotificationService : INotificationService
    {
        public int Count { get; set; } = 0;
        public event Action OnCounterChanged;

        public void IncrementCounter()
        {
            Count++;
            OnCounterChanged?.Invoke();
        }

        public void ResetCounter()
        {
            Count = 0;
            OnCounterChanged?.Invoke();
        }
    }
}