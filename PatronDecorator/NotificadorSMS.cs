namespace PatronDecorator
{
    public class NotificadorSMS : NotificadorDecorador
    {
        public NotificadorSMS(INotificador notificador) : base(notificador)
        {

        }

        public override void EnviarMensaje(string mensaje)
        {
            base.EnviarMensaje(mensaje);
            EnviarSMS(mensaje);
        }

        private void EnviarSMS(string mensaje)
        {
            //Logica para enviar SMS
            Console.WriteLine("Enviando SMS: " + mensaje);
        }
    }


}
