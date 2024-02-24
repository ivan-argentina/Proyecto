<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Usuarios = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenDeCuentaToolStripPro = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeReparacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetalleDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasPorFamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.IvaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IvaComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CarneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambioDePreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarSaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Barra = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.ABMClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenDeCuentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarFacturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CargarPagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenDeCuentaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cBlNg = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSer = New System.Windows.Forms.TextBox
        Me.TxtBd = New System.Windows.Forms.TextBox
        Me.TxtDes = New System.Windows.Forms.TextBox
        Me.txt = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.DtgAr = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.Barra.SuspendLayout()
        CType(Me.DtgAr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.ComprobantesToolStripMenuItem, Me.CuotasToolStripMenuItem, Me.ToolStripMenuItem3, Me.CarneToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.ToolStripMenuItem2, Me.ProveedoresToolStripMenuItem, Me.Usuarios, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem2.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'Usuarios
        '
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(139, 22)
        Me.Usuarios.Text = "Usuarios"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ComprobantesToolStripMenuItem
        '
        Me.ComprobantesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ToolStripMenuItem4, Me.OrdenDeReparacionToolStripMenuItem})
        Me.ComprobantesToolStripMenuItem.Name = "ComprobantesToolStripMenuItem"
        Me.ComprobantesToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ComprobantesToolStripMenuItem.Text = "Comprobantes"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagoToolStripMenuItem, Me.ResumenDeCuentaToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'ResumenDeCuentaToolStripMenuItem
        '
        Me.ResumenDeCuentaToolStripMenuItem.Name = "ResumenDeCuentaToolStripMenuItem"
        Me.ResumenDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ResumenDeCuentaToolStripMenuItem.Text = "Resumen de Cuentas"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarPagosToolStripMenuItem, Me.CargarFacturasToolStripMenuItem, Me.ResumenDeCuentaToolStripPro})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(185, 22)
        Me.ToolStripMenuItem4.Text = "Proveedores"
        '
        'CargarPagosToolStripMenuItem
        '
        Me.CargarPagosToolStripMenuItem.Name = "CargarPagosToolStripMenuItem"
        Me.CargarPagosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarPagosToolStripMenuItem.Text = "Cargar Pagos"
        '
        'CargarFacturasToolStripMenuItem
        '
        Me.CargarFacturasToolStripMenuItem.Name = "CargarFacturasToolStripMenuItem"
        Me.CargarFacturasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarFacturasToolStripMenuItem.Text = "Cargar Facturas"
        '
        'ResumenDeCuentaToolStripPro
        '
        Me.ResumenDeCuentaToolStripPro.Name = "ResumenDeCuentaToolStripPro"
        Me.ResumenDeCuentaToolStripPro.Size = New System.Drawing.Size(180, 22)
        Me.ResumenDeCuentaToolStripPro.Text = "Resumen de Cuenta"
        '
        'OrdenDeReparacionToolStripMenuItem
        '
        Me.OrdenDeReparacionToolStripMenuItem.Name = "OrdenDeReparacionToolStripMenuItem"
        Me.OrdenDeReparacionToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.OrdenDeReparacionToolStripMenuItem.Text = "Orden de Reparacion"
        Me.OrdenDeReparacionToolStripMenuItem.Visible = False
        '
        'CuotasToolStripMenuItem
        '
        Me.CuotasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleDeVentasToolStripMenuItem, Me.VentasPorFamiliaToolStripMenuItem, Me.StockToolStripMenuItem})
        Me.CuotasToolStripMenuItem.Name = "CuotasToolStripMenuItem"
        Me.CuotasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CuotasToolStripMenuItem.Text = "Listados"
        '
        'DetalleDeVentasToolStripMenuItem
        '
        Me.DetalleDeVentasToolStripMenuItem.Name = "DetalleDeVentasToolStripMenuItem"
        Me.DetalleDeVentasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DetalleDeVentasToolStripMenuItem.Text = "Detalle de Ventas"
        '
        'VentasPorFamiliaToolStripMenuItem
        '
        Me.VentasPorFamiliaToolStripMenuItem.Name = "VentasPorFamiliaToolStripMenuItem"
        Me.VentasPorFamiliaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.VentasPorFamiliaToolStripMenuItem.Text = "Ventas por Familia"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IvaVentasToolStripMenuItem, Me.IvaComprasToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripMenuItem3.Text = "Libros de Iva"
        '
        'IvaVentasToolStripMenuItem
        '
        Me.IvaVentasToolStripMenuItem.Name = "IvaVentasToolStripMenuItem"
        Me.IvaVentasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.IvaVentasToolStripMenuItem.Text = "Iva Ventas"
        '
        'IvaComprasToolStripMenuItem
        '
        Me.IvaComprasToolStripMenuItem.Name = "IvaComprasToolStripMenuItem"
        Me.IvaComprasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.IvaComprasToolStripMenuItem.Text = "Iva Compras"
        '
        'CarneToolStripMenuItem
        '
        Me.CarneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.CarneToolStripMenuItem.Name = "CarneToolStripMenuItem"
        Me.CarneToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CarneToolStripMenuItem.Text = "Carnes"
        Me.CarneToolStripMenuItem.Visible = False
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarArticulosToolStripMenuItem, Me.CambioDePreciosToolStripMenuItem, Me.ToolStripMenuItem5, Me.ConfiguracionToolStripMenuItem, Me.ActualizarSaldosToolStripMenuItem, Me.CajaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'BorrarArticulosToolStripMenuItem
        '
        Me.BorrarArticulosToolStripMenuItem.Name = "BorrarArticulosToolStripMenuItem"
        Me.BorrarArticulosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BorrarArticulosToolStripMenuItem.Text = "Etiquetas"
        '
        'CambioDePreciosToolStripMenuItem
        '
        Me.CambioDePreciosToolStripMenuItem.Name = "CambioDePreciosToolStripMenuItem"
        Me.CambioDePreciosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CambioDePreciosToolStripMenuItem.Text = "Cambio de Precios"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem5.Text = "Copia de Seguridad"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'ActualizarSaldosToolStripMenuItem
        '
        Me.ActualizarSaldosToolStripMenuItem.Name = "ActualizarSaldosToolStripMenuItem"
        Me.ActualizarSaldosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ActualizarSaldosToolStripMenuItem.Text = "Actualizar Saldos"
        Me.ActualizarSaldosToolStripMenuItem.Visible = False
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'Barra
        '
        Me.Barra.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barra.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.cBlNg})
        Me.Barra.Location = New System.Drawing.Point(0, 24)
        Me.Barra.Name = "Barra"
        Me.Barra.Padding = New System.Windows.Forms.Padding(0)
        Me.Barra.Size = New System.Drawing.Size(1370, 59)
        Me.Barra.TabIndex = 1
        Me.Barra.Text = "ToolStrip1"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton7.Size = New System.Drawing.Size(56, 56)
        Me.ToolStripButton7.Text = "Buscar Articulos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Super.My.Resources.Resources.Articulo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton1.Size = New System.Drawing.Size(56, 56)
        Me.ToolStripButton1.Text = "A.B.M. Articulos"
        Me.ToolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMClientesToolStripMenuItem, Me.PagosToolStripMenuItem, Me.ResumenDeCuentaToolStripMenuItem1})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 56)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Clientes"
        '
        'ABMClientesToolStripMenuItem
        '
        Me.ABMClientesToolStripMenuItem.Name = "ABMClientesToolStripMenuItem"
        Me.ABMClientesToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ABMClientesToolStripMenuItem.Text = "A.B.M. Clientes"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.PagosToolStripMenuItem.Text = "Cargar Pagos"
        '
        'ResumenDeCuentaToolStripMenuItem1
        '
        Me.ResumenDeCuentaToolStripMenuItem1.Name = "ResumenDeCuentaToolStripMenuItem1"
        Me.ResumenDeCuentaToolStripMenuItem1.Size = New System.Drawing.Size(200, 24)
        Me.ResumenDeCuentaToolStripMenuItem1.Text = "Resumen de Cuenta"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.CargarFacturasToolStripMenuItem1, Me.CargarPagosToolStripMenuItem1, Me.ResumenDeCuentaToolStripMenuItem2})
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 56)
        Me.ToolStripButton3.Text = "A.B.M. Clientes"
        Me.ToolStripButton3.ToolTipText = "Proveedores"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(200, 24)
        Me.ToolStripMenuItem6.Text = "A.B.M Proveedores"
        '
        'CargarFacturasToolStripMenuItem1
        '
        Me.CargarFacturasToolStripMenuItem1.Name = "CargarFacturasToolStripMenuItem1"
        Me.CargarFacturasToolStripMenuItem1.Size = New System.Drawing.Size(200, 24)
        Me.CargarFacturasToolStripMenuItem1.Text = "Cargar Facturas"
        '
        'CargarPagosToolStripMenuItem1
        '
        Me.CargarPagosToolStripMenuItem1.Name = "CargarPagosToolStripMenuItem1"
        Me.CargarPagosToolStripMenuItem1.Size = New System.Drawing.Size(200, 24)
        Me.CargarPagosToolStripMenuItem1.Text = "Cargar Pagos"
        '
        'ResumenDeCuentaToolStripMenuItem2
        '
        Me.ResumenDeCuentaToolStripMenuItem2.Name = "ResumenDeCuentaToolStripMenuItem2"
        Me.ResumenDeCuentaToolStripMenuItem2.Size = New System.Drawing.Size(200, 24)
        Me.ResumenDeCuentaToolStripMenuItem2.Text = "Resumen de Cuenta"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton4.Size = New System.Drawing.Size(56, 56)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Facturar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 59)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Super.My.Resources.Resources.Salir
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolStripButton5.Size = New System.Drawing.Size(56, 56)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.ToolTipText = "Salir del sistema"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 59)
        '
        'cBlNg
        '
        Me.cBlNg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBlNg.Image = Global.Super.My.Resources.Resources.theater1
        Me.cBlNg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBlNg.Name = "cBlNg"
        Me.cBlNg.Padding = New System.Windows.Forms.Padding(10)
        Me.cBlNg.Size = New System.Drawing.Size(56, 56)
        Me.cBlNg.Text = "ToolStripButton6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1300, 678)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TR"
        '
        'TxtSer
        '
        Me.TxtSer.Location = New System.Drawing.Point(95, 300)
        Me.TxtSer.Name = "TxtSer"
        Me.TxtSer.Size = New System.Drawing.Size(91, 20)
        Me.TxtSer.TabIndex = 5
        Me.TxtSer.Text = "Ntivan"
        Me.TxtSer.Visible = False
        '
        'TxtBd
        '
        Me.TxtBd.Location = New System.Drawing.Point(89, 338)
        Me.TxtBd.Name = "TxtBd"
        Me.TxtBd.Size = New System.Drawing.Size(96, 20)
        Me.TxtBd.TabIndex = 6
        Me.TxtBd.Text = "Super"
        Me.TxtBd.Visible = False
        '
        'TxtDes
        '
        Me.TxtDes.Location = New System.Drawing.Point(84, 375)
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.Size = New System.Drawing.Size(101, 20)
        Me.TxtDes.TabIndex = 7
        Me.TxtDes.Text = "D:\Copia de Seguridad"
        Me.TxtDes.Visible = False
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(611, 219)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(70, 20)
        Me.txt.TabIndex = 8
        Me.txt.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(284, 482)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 39)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(102, 490)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(83, 20)
        Me.Text1.TabIndex = 15
        Me.Text1.Visible = False
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(102, 516)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(83, 20)
        Me.Text2.TabIndex = 16
        Me.Text2.Visible = False
        '
        'DtgAr
        '
        Me.DtgAr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgAr.Location = New System.Drawing.Point(260, 325)
        Me.DtgAr.Name = "DtgAr"
        Me.DtgAr.Size = New System.Drawing.Size(340, 115)
        Me.DtgAr.TabIndex = 11
        Me.DtgAr.Visible = False
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 719)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DtgAr)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.TxtDes)
        Me.Controls.Add(Me.TxtBd)
        Me.Controls.Add(Me.TxtSer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Barra)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        CType(Me.DtgAr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Barra As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprobantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cBlNg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDePreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeReparacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IvaVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IvaComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ResumenDeCuentaToolStripPro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarPagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtSer As System.Windows.Forms.TextBox
    Friend WithEvents TxtBd As System.Windows.Forms.TextBox
    Friend WithEvents TxtDes As System.Windows.Forms.TextBox
    Friend WithEvents CuotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents BorrarArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarSaldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalleDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ABMClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDeCuentaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CargarFacturasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarPagosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDeCuentaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasPorFamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DtgAr As System.Windows.Forms.DataGridView
    Friend WithEvents CarneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
