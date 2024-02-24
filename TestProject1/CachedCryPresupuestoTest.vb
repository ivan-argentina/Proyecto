Imports System

Imports CrystalDecisions.Shared

Imports CrystalDecisions.CrystalReports.Engine

Imports CrystalDecisions.ReportSource

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Super



'''<summary>
'''Se trata de una clase de prueba para CachedCryPresupuestoTest y se pretende que
'''contenga todas las pruebas unitarias CachedCryPresupuestoTest.
'''</summary>
<TestClass()> _
Public Class CachedCryPresupuestoTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Obtiene o establece el contexto de la prueba que proporciona
    '''la información y funcionalidad para la ejecución de pruebas actual.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Atributos de prueba adicionales"
    '
    'Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
    '
    'Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize para ejecutar código antes de ejecutar cada prueba
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Una prueba de ShareDBLogonInfo
    '''</summary>
    <TestMethod()> _
    Public Sub ShareDBLogonInfoTest()
        Dim target As ICachedReport = New CachedCryPresupuesto ' TODO: Inicializar en un valor adecuado
        Dim expected As Boolean = False ' TODO: Inicializar en un valor adecuado
        Dim actual As Boolean
        target.ShareDBLogonInfo = expected
        actual = target.ShareDBLogonInfo
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    End Sub

    '''<summary>
    '''Una prueba de IsCacheable
    '''</summary>
    <TestMethod()> _
    Public Sub IsCacheableTest()
        Dim target As ICachedReport = New CachedCryPresupuesto ' TODO: Inicializar en un valor adecuado
        Dim expected As Boolean = False ' TODO: Inicializar en un valor adecuado
        Dim actual As Boolean
        target.IsCacheable = expected
        actual = target.IsCacheable
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    End Sub

    '''<summary>
    '''Una prueba de CacheTimeOut
    '''</summary>
    <TestMethod()> _
    Public Sub CacheTimeOutTest()
        Dim target As ICachedReport = New CachedCryPresupuesto ' TODO: Inicializar en un valor adecuado
        Dim expected As TimeSpan = New TimeSpan ' TODO: Inicializar en un valor adecuado
        Dim actual As TimeSpan
        target.CacheTimeOut = expected
        actual = target.CacheTimeOut
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    End Sub

    '''<summary>
    '''Una prueba de GetCustomizedCacheKey
    '''</summary>
    <TestMethod()> _
    Public Sub GetCustomizedCacheKeyTest()
        Dim target As ICachedReport = New CachedCryPresupuesto ' TODO: Inicializar en un valor adecuado
        Dim request As RequestContext = Nothing ' TODO: Inicializar en un valor adecuado
        Dim expected As String = String.Empty ' TODO: Inicializar en un valor adecuado
        Dim actual As String
        actual = target.GetCustomizedCacheKey(request)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    End Sub

    '''<summary>
    '''Una prueba de CreateReport
    '''</summary>
    <TestMethod()> _
    Public Sub CreateReportTest()
        Dim target As ICachedReport = New CachedCryPresupuesto ' TODO: Inicializar en un valor adecuado
        Dim expected As ReportDocument = Nothing ' TODO: Inicializar en un valor adecuado
        Dim actual As ReportDocument
        actual = target.CreateReport
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Compruebe la exactitud de este método de prueba.")
    End Sub

    '''<summary>
    '''Una prueba de Constructor CachedCryPresupuesto
    '''</summary>
    <TestMethod()> _
    Public Sub CachedCryPresupuestoConstructorTest()
        Dim target As CachedCryPresupuesto = New CachedCryPresupuesto
        Assert.Inconclusive("TODO: Implementar código para comprobar el destino")
    End Sub
End Class
