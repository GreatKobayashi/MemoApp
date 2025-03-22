namespace MemoApp.Domain.Entities
{
    public class MemoEntity
    {
        public MemoEntity(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public string Title { get; private set; }
        public string Body { get; private set; }
    }
}
