
'/******************************************************************************
'*   Autor: Business Support And Development Unit 			                   *
'*   Versión: 7.0 			                         	                       *
'*                                                                             *
'*   Este código es gratuito y permite integrar de forma rápida y sencilla     *
'*   impresoras fiscales EPSON de nueva generación (TM-900FA) utilizando la    *
'*   librería de alto nivel (EpsonFiscalInterface).                            *
'*                                                                             *
'*   Para implementarla las funciones de la libreria (.dll) usted debe incluir *
'*   el modulo 'EpsonFiscalInterface' en su proyecto.                          *
'*                                                                             *
'*   Es necerio importar System.text en el formulario donde se quiera usar las *
'*   funciones de la DLL ya que requiere usar varibales del tipo StringBuilder *
'*                                                                             *                                                                                       
'*   Este software se entrega con fines didácticos y sin garantía alguna.      *
'*   EPSON ARGENTINA S.R.L. NO ASUME responsabilidad legal alguna.	           *
'*   El programador usa este software bajo su propio riesgo y responsabilidad. *
'******************************************************************************/



Imports System.Text

Module epsonfiscalinterface

    '-----------------------------------------------------------------------------
    'Typedef from exported Prototypes of "EpsonFiscalInterface.h"
    '-----------------------------------------------------------------------------
    Public Declare Function ConfigurarVelocidad Lib "EpsonFiscalInterface.dll" (ByVal velocidad As Integer) As Integer
    Public Declare Function ConfigurarPuerto Lib "EpsonFiscalInterface.dll" (ByVal puerto As String) As Integer
    Public Declare Function Conectar Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function Desconectar Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function Cancelar Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ComenzarLog Lib "EpsonFiscalInterface.dll" (ByVal incluir_tramas_bajo_nivel As Boolean) As Integer
    Public Declare Function DeternerLog Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function PausarLog Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ReanudarLog Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ConsultarUltimoError Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ConsultarDescripcionDeError Lib "EpsonFiscalInterface.dll" (ByVal nro_error As Integer, ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarVersionDll Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer, ByRef mayor As Integer, ByRef menor As Integer) As Integer
    Public Declare Function ConsultarVersionEquipo Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer, ByRef mayor As Integer, ByRef menor As Integer) As Integer
    Public Declare Function ConsultarNumeroPuntoDeVenta Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarNumeroComprobanteUltimo Lib "EpsonFiscalInterface.dll" (ByVal tipo_de_comprobante As String, ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarNumeroComprobanteActual Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarTipoComprobanteActual Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarSubTotalBrutoComprobanteActual Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarSubTotalNetoComprobanteActual Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ConsultarEstado Lib "EpsonFiscalInterface.dll" (ByVal id_consulta As Integer, ByRef respuesta As Integer) As Integer
    Public Declare Function EstablecerEncabezado Lib "EpsonFiscalInterface.dll" (ByVal numero_encabezado As Integer, ByVal descripcion As String) As Integer
    Public Declare Function ConsultarEncabezado Lib "EpsonFiscalInterface.dll" (ByVal numero_encabezado As Integer, ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function EstablecerCola Lib "EpsonFiscalInterface.dll" (ByVal numero_cola As Integer, ByVal descripcion As String) As Integer
    Public Declare Function ConsultarCola Lib "EpsonFiscalInterface.dll" (ByVal numero_cola As Integer, ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function EstablecerFechaHora Lib "EpsonFiscalInterface.dll" (ByVal fecha_hora As String) As Integer
    Public Declare Function ConsultarFechaHora Lib "EpsonFiscalInterface.dll" (ByVal respuesta As StringBuilder, ByVal respuesta_largo_maximo As Integer) As Integer
    Public Declare Function ImprimirAuditoria Lib "EpsonFiscalInterface.dll" (ByVal id_modificador As Integer, ByVal desde As String, ByVal hasta As String) As Integer
    Public Declare Function Descargar Lib "EpsonFiscalInterface.dll" (ByVal desde As String, ByVal hasta As String, ByVal path As String) As Integer
    Public Declare Function DescargarPeriodoPendiente Lib "EpsonFiscalInterface.dll" (ByVal path As String) As Integer
    Public Declare Function ConfimarDescarga Lib "EpsonFiscalInterface.dll" (ByVal hasta As String) As Integer
    Public Declare Function ConsultarFechaPrimerJornadaPendiente Lib "EpsonFiscalInterface.dll" (ByVal respuesta_periodo_pendiente As StringBuilder, ByVal respuesta_periodo_pendiente_largo_maximo As Integer) As Integer
    Public Declare Function CargarDatosCliente Lib "EpsonFiscalInterface.dll" (ByVal nombre_o_razon_social1 As String, ByVal nombre_o_razon_social2 As String, ByVal domicilio1 As String, ByVal domicilio2 As String, ByVal domicilio3 As String, ByVal id_tipo_documento As Integer, ByVal numero_documento As String, ByVal id_responsabilidad_iva As Integer) As Integer
    Public Declare Function CargarComprobanteAsociado Lib "EpsonFiscalInterface.dll" (ByVal descripcion As String) As Integer
    Public Declare Function AbrirComprobante Lib "EpsonFiscalInterface.dll" (ByVal id_tipo_documento As Integer) As Integer
    Public Declare Function CargarTextoExtra Lib "EpsonFiscalInterface.dll" (ByVal descripcion As String) As Integer
    Public Declare Function ImprimirItem Lib "EpsonFiscalInterface.dll" (ByVal id_modificador As Integer, ByVal descripcion As String, ByVal cantidad As String, ByVal precio As String, ByVal id_tasa_iva As Integer, ByVal ii_id As Integer, ByVal ii_valor As String, ByVal id_codigo As Integer, ByVal codigo As String, ByVal codigo_unidad_matrix As String, ByVal codigo_unidad_medida As Integer) As Integer
    Public Declare Function ImprimirTextoLibre Lib "EpsonFiscalInterface.dll" (ByVal descripcion As String) As Integer
    Public Declare Function CargarAjuste Lib "EpsonFiscalInterface.dll" (ByVal id_modificador As Integer, ByVal descripcion As String, ByVal monto As String, ByVal id_tasa_iva As Integer, ByVal codigo_interno As String) As Integer
    Public Declare Function CargarOtrosTributos Lib "EpsonFiscalInterface.dll" (ByVal codigo_otros_tributos As Integer, ByVal descripcion As String, ByVal monto As String, ByVal id_tasa_iva As Integer) As Integer
    Public Declare Function CargarPago Lib "EpsonFiscalInterface.dll" (ByVal id_modificador As Integer, ByVal codigo_forma_pago As Integer, ByVal cantidad_cuotas As Integer, ByVal monto As String, ByVal descripción_cupones As String, ByVal descripcion As String, ByVal descripcion_extra1 As String, ByVal descripcion_extra2 As String) As Integer
    Public Declare Function ImprimirSubtotal Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function CerrarComprobante Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ImprimirCierreX Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ImprimirCierreZ Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function CargarLogo Lib "EpsonFiscalInterface.dll" (ByVal path As String) As Integer
    Public Declare Function EliminarLogo Lib "EpsonFiscalInterface.dll" () As Integer


    Public Declare Function EnviarComando Lib "EpsonFiscalInterface.dll" (ByVal comando As String) As Integer
    Public Declare Function ObtenerCodigoRetorno Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ObtenerEstadoFiscal Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ObtenerEstadoImpresora Lib "EpsonFiscalInterface.dll" () As Integer
    Public Declare Function ObtenerRespuestaExtendida Lib "EpsonFiscalInterface.dll" (ByVal numero_campo As Integer, ByVal buffer_salida As IntPtr, ByVal largo_buffer_salida As Integer, ByRef largo_final_buffer_salida As Integer) As Integer

    ' -----------------------------------------------------------------------------
    ' GLOBAL DEFINES AREA
    ' -----------------------------------------------------------------------------
    Public Const ERROR_NINGUNO = 0

    Public Const ID_TIPO_COMPROBANTE_TIQUET = 1                            ' "83"  Tique
    Public Const ID_TIPO_COMPROBANTE_TIQUE_FACTURA = 2                     ' "81"  Tique Factura A, "82" Tique Factura B, "111" Tique Factura C, "118" Tique Factura M
    Public Const ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_CREDITO = 3             ' "110" Tique Nota de Credito, "112" Tique Nota de Credito A, "113" Tique Nota de Credito B, "114" Tique Nota de Credito C, "119" Tique Nota de Credito M
    Public Const ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_DEBITO = 4              ' "115" Tique Nota de Debito A, "116" Tique Nota de Debito B, "117" Tique Nota de Debito C, "120" Tique Nota de Debito M
    Public Const ID_TIPO_COMPROBANTE_DNFH_GENERIC = 21                     ' "910" DNFH Documento Generico 
    Public Const ID_TIPO_COMPROBANTE_DNFH_INTERNAL_USE = 22                ' "950" DNFH Documento de uso interno 
    Public Const ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_REMITO_R = 51         ' "91"  DNFH Valorizado Remito R 
    Public Const ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_REMITO_X = 52         ' "901" DNFH Valorizado Remito X 
    Public Const ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_RECIBO_X = 53         ' "902" DNFH Valorizado Recibo X 
    Public Const ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_PRESUPUESTO_X = 54    ' "903" DNFH Valorizado Presupuesto X 
    Public Const ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_DONACION = 55         ' "907" DNFH Valorizado Comprobante Donacion 

    Public Const ID_TIPO_DOCUMENTO_NINGUNO = 0
    Public Const ID_TIPO_DOCUMENTO_DNI = 1
    Public Const ID_TIPO_DOCUMENTO_CUIL = 2
    Public Const ID_TIPO_DOCUMENTO_CUIT = 3
    Public Const ID_TIPO_DOCUMENTO_CEDULA_IDENTIDAD = 4
    Public Const ID_TIPO_DOCUMENTO_PASAPORTE = 5
    Public Const ID_TIPO_DOCUMENTO_LIB_CIVICA = 6
    Public Const ID_TIPO_DOCUMENTO_LIB_ENROLAMIENTO = 7

    Public Const ID_RESPONSABILIDAD_IVA_NINGUNO = 0
    Public Const ID_RESPONSABILIDAD_IVA_RESPONSABLE_INSCRIPTO = 1
    Public Const ID_RESPONSABILIDAD_IVA_NO_RESPONSABLE = 3
    Public Const ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA = 4
    Public Const ID_RESPONSABILIDAD_IVA_CONSUMIDOR_FINAL = 5
    Public Const ID_RESPONSABILIDAD_IVA_EXENTO = 6
    Public Const ID_RESPONSABILIDAD_IVA_NO_CATEGORIZADO = 7
    Public Const ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA_SOCIAL = 8
    Public Const ID_RESPONSABILIDAD_IVA_CONTRIBUYENTE_EVENTUAL = 9
    Public Const ID_RESPONSABILIDAD_IVA_CONTRIBUYENTE_EVENTUAL_SOCIAL = 10
    Public Const ID_RESPONSABILIDAD_IVA_MONOTRIBUTO_INDEPENDIENTE_PROMOVIDO = 11

    Public Const ID_MODIFICADOR_AGREGAR_ITEM = 200
    Public Const ID_MODIFICADOR_ANULAR_ITEM = 201
    Public Const ID_MODIFICADOR_AGREGAR_ITEM_RETORNO_ENVASES = 202
    Public Const ID_MODIFICADOR_ANULAR_ITEM_RETORNO_ENVASES = 203
    Public Const ID_MODIFICADOR_AGREGAR_ITEM_BONIFICACION = 204
    Public Const ID_MODIFICADOR_ANULAR_ITEM_BONIFICACION = 205
    Public Const ID_MODIFICADOR_AGREGAR_ITEM_DESCUENTO = 206
    Public Const ID_MODIFICADOR_ANULAR_ITEM_DESCUENTO = 207
    Public Const ID_MODIFICADOR_AGREGAR_ITEM_ANTICIPO = 208
    Public Const ID_MODIFICADOR_ANULAR_ITEM_ANTICIPO = 209
    Public Const ID_MODIFICADOR_AGREGAR_ITEM_DESCUENTO_ANTICIPO = 210
    Public Const ID_MODIFICADOR_ANULAR_ITEM_DESCUENTO_ANTICIPO = 211
    Public Const ID_MODIFICADOR_DESCUENTO = 400
    Public Const ID_MODIFICADOR_AJUSTE = 401
    Public Const ID_MODIFICADOR_AJUSTE_NEGATIVO = 402
    Public Const ID_MODIFICADOR_AUDITORIA_DETALLADA = 500
    Public Const ID_MODIFICADOR_AUDITORIA_RESUMIDA = 501

    Public Const ID_MODIFICADOR_AGREGAR = ID_MODIFICADOR_AGREGAR_ITEM
    Public Const ID_MODIFICADOR_ANULAR = ID_MODIFICADOR_ANULAR_ITEM

    Public Const ID_TASA_IVA_NINGUNO = 0
    Public Const ID_TASA_IVA_EXENTO = 1
    Public Const ID_TASA_IVA_10_50 = 4
    Public Const ID_TASA_IVA_21_00 = 5

    Public Const ID_IMPUESTO_NINGUNO = 0
    Public Const ID_IMPUESTO_INTERNO_FIJO = 1
    Public Const ID_IMPUESTO_INTERNO_PORCENTUAL = 2

    Public Const ID_CODIGO_INTERNO = 1
    Public Const ID_CODIGO_MATRIX = 2

    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_SIN_DESCRIPCION = 0
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO = 1
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_METROS = 2
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_METRO_CUADRADO = 3
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_METRO_CUBICO = 4
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_LITROS = 5
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD = 7
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_PAR = 8
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_DOCENA = 9
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_QUILATE = 10
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILLAR = 11
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_U_INTER_ACT_ANTIB = 12
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD_INT_ACT_INMUNG = 13
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO = 14
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILIMETRO = 15
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILIMETRO_CUBICO = 16
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOMETRO = 17
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_HECTOLITRO = 18
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_UNIDAD_INT_ACT_INMUNG = 19
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_CENTIMETRO = 20
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_ACTIVO = 21
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO_ACTIVO = 22
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO_BASE = 23
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_UIACTHOR = 24
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_JGO_PQT_MAZO_NAIPES = 25
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTHOR = 26
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_CENTIMETRO_CUBICO = 27
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_UIACTANT = 28
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_TONELADA = 29
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_DECAMETRO_CUBICO = 30
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_HECTOMETRO_CUBICO = 31
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOMETRO_CUBICO = 32
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MICROGRAMO = 33
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_NANOGRAMO = 34
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_PICOGRAMO = 35
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTANT = 36
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_UIACTIG = 37
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILIGRAMO = 41
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILILITRO = 47
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_CURIE = 48
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MILICURIE = 49
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MICROCURIE = 50
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_U_INTER_ACT_HORMONAL = 51
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_U_INTER_ACT_HORMONAL = 52
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_BASE = 53
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_GRUESA = 54
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTIG = 55
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_BRUTO = 61
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_PACK = 62
    Public Const AFIP_CODIGO_UNIDAD_MEDIDA_HORMA = 63

    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_IMPUESTOS_NACIONALES = 1
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_IMPUESTOS_PROVINCIAL = 2
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_IMPUESTO_MUNICIPAL = 3
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_IMPUESTO_INTERNOS = 4
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_INGRESOS_BRUTOS = 5
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_PERCEPCION_DE_IVA = 6
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_PERCEPCION_DE_INGRESOS_BRUTOS = 7
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_PERCEPCION_POR_IMPUESTOS_MUNICIPALES = 8
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_OTRAS_PERCEPCIONES = 9
    Public Const AFIP_CODIGO_OTROS_TRIBUTOS_OTROS = 99

    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CARTA_DE_CREDITO_DOCUMENTARIO = 1
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CARTAS_DE_CREDITO_SIMPLE = 2
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CHEQUE = 3
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CHEQUES_CANCELATORIOS = 4
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CREDITO_DOCUMENTARIO = 5
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_CUENTA_CORRIENTE = 6
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_DEPOSITO = 7
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_EFECTIVO = 8
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_ENDOSO_DE_CHEQUE = 9
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_FACTURA_DE_CREDITO = 10
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_GARANTIAS_BANCARIAS = 11
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_GIROS = 12
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_LETRAS_DE_CAMBIO = 13
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_MEDIOS_DE_PAGO_DE_COMERCIO_EXTERIOR = 14
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_ORDEN_DE_PAGO_DOCUMENTARIA = 15
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_ORDEN_DE_PAGO_SIMPLE = 16
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_PAGO_CONTRA_REEMBOLSO = 17
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_REMESA_DOCUMENTARIA = 18
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_REMESA_SIMPLE = 19
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_TARJETA_DE_CREDITO = 20
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_TARJETA_DE_DEBITO = 21
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_TICKET = 22
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_TRANSFERENCIA_BANCARIA = 23
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_TRANSFERENCIA_NO_BANCARIA = 24
    Public Const AFIP_CODIGO_FORMA_DE_PAGO_OTROS_MEDIOS = 99

    Public Const DOC_EN_PROGRESO = 1003
    Public Const SUBESTADOS = 1006
    Public Const JORNADA_FISCAL = 1007
    Public Const ESTADO_MEM_TRANSACCIONES = 1009
    Public Const ESTADO_MEM_FISCAL = 1011
    Public Const MODO_TECNICO = 1012
    Public Const ESTADO_CERTIFICADOS_DIGITALES = 1013
    Public Const MODO_FUNCIONAMIENTO_EQUIPO = 1015
    Public Const ESTADO_ESTACION_RECIBOS = 7001
    Public Const ESTADO_ESTACION_JOURNAL = 7003
    Public Const ESTADO_ESTACION_SLIP_SENSOR_VALIDACION = 7004
    Public Const ESTADO_ESTACION_SLIP_SENSOR_TOF = 7005
    Public Const ESTADO_ESTACION_SLIP_SENSOR_BOF = 7006
    Public Const ESTADO_ESTACION_SLIP_VALIDACION_SENSOR_ESPERA = 7008
    Public Const ESTADO_ESTACION_SELECCIONADA = 7010
    Public Const ESTADO_CAJON_DINERO = 7012
    Public Const ESTADO_TAPA = 7013
    Public Const IMPRESORA_CON_ERROR = 7014
    Public Const IMPRESORA_EN_LINEA = 7015
    Public Const ESTADO_CONEXION = 9003

    Public Const MAX_ANSWER = 200
    Public Const MAX_DESCRIPTION = 500
    Public Const MAX_COMMAND = 1000

    Public retorno As Integer

End Module
