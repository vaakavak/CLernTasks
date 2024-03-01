
// Queue - очередь (FIFO - first in - first out)

Queue<string> patients = new Queue<string>();

patients.Enqueue("Василий");   // Enqueue - добавление в очередь
patients.Enqueue("Дмитрий");
patients.Enqueue("Георгий");
patients.Enqueue("Всевлад");
patients.Enqueue("Николай");
patients.Enqueue("Пупович");
patients.Enqueue("Алексан");

Console.WriteLine("Сейчас на прием идет " + patients.Dequeue()); // Dequeue - удаление из очереди (сначало предоставление, потом удаление)
Console.WriteLine("Следующий в очереди " + patients.Peek());     // Посмотреть кто следующий Peek (просто предоставление)

foreach (var patient in patients)
{
    Console.WriteLine(patient);
}
