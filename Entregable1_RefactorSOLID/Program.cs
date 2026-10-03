using Entregable1_RefactorSOLID.Services;

// Instanciación de servicios desacoplados bajo el Principio de Responsabilidad Única (SRP)
var datosConsultaService = new DatosConsultaService();
var generadorReporteService = new GeneradorReporteService();
var notificadorCorreoService = new NotificadorCorreoService();
var almacenamientoArchivoService = new AlmacenamientoArchivoService();

var procesador = new ReporteProcesador(
    datosConsultaService,
    generadorReporteService,
    notificadorCorreoService,
    almacenamientoArchivoService
);

procesador.Procesar();

// Mantiene la aplicación abierta para permitir visualizar los mensajes en consola
Console.ReadLine();
