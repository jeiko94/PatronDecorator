namespace PatronDecorator
{
    public class NotificadorDecorador : INotificador
    {
        protected INotificador _notifificador;

        public NotificadorDecorador(INotificador notificador)
        {
            _notifificador = notificador;
        }

        public virtual void EnviarMensaje(string mensaje)
        {
            _notifificador.EnviarMensaje(mensaje);
        }
    }
}
