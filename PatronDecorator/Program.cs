using PatronDecorator;

class Program
{
    static void Main(string[] args)
    {
        // Componente base
        INotificador notificador = new NotificadorBase();

        // Agregar decoradores según se requiera
        notificador = new NotificadorEmail(notificador);
        notificador = new NotificadorSMS(notificador);
        notificador = new NotificadorPush(notificador);

        // Enviar mensaje
        notificador.EnviarMensaje("¡Este es un mensaje de prueba!");
    }
}
