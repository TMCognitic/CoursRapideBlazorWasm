namespace CoursRapideBlazorWasm.Infrastructures
{
    public class Mediator<TMessage>
    {
        private static Mediator<TMessage>? _instance;

        public static Mediator<TMessage> Instance
        {
            get
            {
                return _instance ??= new Mediator<TMessage>();
            }
        }

        private Mediator()
        {

        }

        public event Action<object, TMessage>? Broadcaster;

        public void Send(object sender, TMessage message)
        {
            Broadcaster?.Invoke(sender, message);
        }
    }
}
