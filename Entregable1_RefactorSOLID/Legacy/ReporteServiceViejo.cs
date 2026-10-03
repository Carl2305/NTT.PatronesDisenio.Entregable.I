namespace Entregable1_RefactorSOLID.Legacy;

// EJEMPLO DE LA CLASE INICIAL MAL DISEÑADA (VIOLA SRP):
// Esta clase concentraba múltiples responsabilidades independientes:
// 1. Acceso a datos
// 2. Generación de reportes
// 3. Envío de correos
// 4. Persistencia en disco
//
// Refactorizado siguiendo el Principio de Responsabilidad Única (SRP)
// en las clases contenidas en los namespaces Interfaces y Services.

public class ReporteServiceViejo
{
    public void ConsultarDatos()
    {
        Console.WriteLine("Consultar datos");
    }

    public void GenerarReporte()
    {
        Console.WriteLine("Generar reporte");
    }

    public void EnviarCorreo()
    {
        Console.WriteLine("Enviar correo");
    }

    public void GuardarArchivo()
    {
        Console.WriteLine("Guardar archivo");
    }
}
