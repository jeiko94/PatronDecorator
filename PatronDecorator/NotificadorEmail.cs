namespace PatronDecorator
{
    public class NotificadorEmail : NotificadorDecorador
    {
        public NotificadorEmail(INotificador notificador) : base(notificador)
        {
        }

        public override void EnviarMensaje(string mensaje)
        {
            base.EnviarMensaje(mensaje);
            EnviarEmail(mensaje);
        }

        private void EnviarEmail(string mensaje)
        {
            // Lógica para enviar email
            Console.WriteLine("Enviando email: " + mensaje);
        }
    }
}
