namespace Entregable1_RefactorSOLID.Services;

using Entregable1_RefactorSOLID.Interfaces;

public class ReporteProcesador
{
    private readonly IDatosConsultaService _datosConsultaService;
    private readonly IGeneradorReporteService _generadorReporteService;
    private readonly INotificadorCorreoService _notificadorCorreoService;
    private readonly IAlmacenamientoArchivoService _almacenamientoArchivoService;

    public ReporteProcesador(
        IDatosConsultaService datosConsultaService,
        IGeneradorReporteService generadorReporteService,
        INotificadorCorreoService notificadorCorreoService,
        IAlmacenamientoArchivoService almacenamientoArchivoService)
    {
        _datosConsultaService = datosConsultaService;
        _generadorReporteService = generadorReporteService;
        _notificadorCorreoService = notificadorCorreoService;
        _almacenamientoArchivoService = almacenamientoArchivoService;
    }

    public void Procesar()
    {
        _datosConsultaService.ConsultarDatos();
        _generadorReporteService.GenerarReporte();
        _notificadorCorreoService.EnviarCorreo();
        _almacenamientoArchivoService.GuardarArchivo();
    }
}
