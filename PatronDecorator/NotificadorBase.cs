namespace PatronDecorator
{
    public class NotificadorBase : INotificador
    {
        public void EnviarMensaje(string mensaje)
        {
            //Funcionalidad básica (puede estar vacía o incluir alguna lógica por defecto)
            Console.WriteLine("Notificación base: " + mensaje);
        }
    }
}
