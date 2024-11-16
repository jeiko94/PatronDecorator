namespace PatronDecorator
{
    public class NotificadorPush : NotificadorDecorador
    {
        public NotificadorPush(INotificador notificador) : base(notificador)
        {
        }

        public override void EnviarMensaje(string mensaje)
        {
            base.EnviarMensaje(mensaje);
            EnviarPush(mensaje);
        }

        private void EnviarPush(string mensaje)
        {
            // Lógica para enviar notificación push
            Console.WriteLine("Enviando notificación push: " + mensaje);
        }
    }

}
