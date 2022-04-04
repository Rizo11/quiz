namespace quiz.Services;


interface INotificationService
{
    int Count { get; set; }
    void IncrementCounter();
    void ResetCounter();

    event Action OnCounterChanged;
}