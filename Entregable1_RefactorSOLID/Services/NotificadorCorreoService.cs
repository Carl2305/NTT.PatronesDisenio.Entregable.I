namespace Entregable1_RefactorSOLID.Services;

using Entregable1_RefactorSOLID.Interfaces;

public class NotificadorCorreoService : INotificadorCorreoService
{
    public void EnviarCorreo()
    {
        Console.WriteLine("Enviar correo");
    }
}
