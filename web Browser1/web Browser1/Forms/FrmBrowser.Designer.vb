<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrowser))
        Me.AddressBar = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AddressBox1 = New Awesomium.Windows.Forms.AddressBox()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.webSession = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnForward = New System.Windows.Forms.ToolStripButton()
        Me.btnSecure = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tbAddressBox = New System.Windows.Forms.ToolStripTextBox()
        Me.btnFavourites = New System.Windows.Forms.ToolStripButton()
        Me.btnReload = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchProvider = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnHome = New System.Windows.Forms.ToolStripButton()
        Me.tbSearchBox = New System.Windows.Forms.ToolStripTextBox()
        Me.btnMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VS2012LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2012LightTheme()
        Me.AddressBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddressBar
        '
        Me.AddressBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnForward, Me.btnSecure, Me.tbAddressBox, Me.btnFavourites, Me.btnReload, Me.btnSearchProvider, Me.tbSearchBox, Me.btnSearch, Me.btnHome, Me.btnMenu})
        Me.AddressBar.Location = New System.Drawing.Point(0, 0)
        Me.AddressBar.Name = "AddressBar"
        Me.AddressBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.AddressBar.Size = New System.Drawing.Size(725, 25)
        Me.AddressBar.TabIndex = 0
        Me.AddressBar.Text = "AddressBar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 347)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(725, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AddressBox1
        '
        Me.AddressBox1.AcceptsReturn = True
        Me.AddressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AddressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AddressBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressBox1.Location = New System.Drawing.Point(0, 25)
        Me.AddressBox1.Name = "AddressBox1"
        Me.AddressBox1.Size = New System.Drawing.Size(725, 20)
        Me.AddressBox1.TabIndex = 2
        Me.AddressBox1.URL = Nothing
        Me.AddressBox1.WebControl = Nothing
        '
        'WebControl1
        '
        Me.WebControl1.Location = New System.Drawing.Point(293, 131)
        Me.WebControl1.Size = New System.Drawing.Size(262, 95)
        Me.WebControl1.Source = New System.Uri("http://www.google.gr/", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 3
        '
        'webSession
        '
        Me.webSession.Views.Add(Me.WebControl1)
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(23, 22)
        Me.btnBack.Text = "btnBack"
        '
        'btnForward
        '
        Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(23, 22)
        Me.btnForward.Text = "ToolStripButton2"
        '
        'btnSecure
        '
        Me.btnSecure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSecure.Image = CType(resources.GetObject("btnSecure.Image"), System.Drawing.Image)
        Me.btnSecure.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSecure.Name = "btnSecure"
        Me.btnSecure.Size = New System.Drawing.Size(29, 22)
        Me.btnSecure.Text = "ToolStripDropDownButton1"
        '
        'tbAddressBox
        '
        Me.tbAddressBox.Name = "tbAddressBox"
        Me.tbAddressBox.Size = New System.Drawing.Size(100, 25)
        '
        'btnFavourites
        '
        Me.btnFavourites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFavourites.Image = CType(resources.GetObject("btnFavourites.Image"), System.Drawing.Image)
        Me.btnFavourites.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFavourites.Name = "btnFavourites"
        Me.btnFavourites.Size = New System.Drawing.Size(23, 22)
        Me.btnFavourites.Text = "ToolStripButton3"
        '
        'btnReload
        '
        Me.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReload.Image = CType(resources.GetObject("btnReload.Image"), System.Drawing.Image)
        Me.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(23, 22)
        Me.btnReload.Text = "ToolStripButton4"
        '
        'btnSearchProvider
        '
        Me.btnSearchProvider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearchProvider.Image = CType(resources.GetObject("btnSearchProvider.Image"), System.Drawing.Image)
        Me.btnSearchProvider.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearchProvider.Name = "btnSearchProvider"
        Me.btnSearchProvider.Size = New System.Drawing.Size(29, 22)
        Me.btnSearchProvider.Text = "ToolStripDropDownButton2"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "ToolStripButton1"
        '
        'btnHome
        '
        Me.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(23, 22)
        Me.btnHome.Text = "ToolStripButton2"
        '
        'tbSearchBox
        '
        Me.tbSearchBox.Name = "tbSearchBox"
        Me.tbSearchBox.Size = New System.Drawing.Size(100, 25)
        '
        'btnMenu
        '
        Me.btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(29, 22)
        Me.btnMenu.Text = "ToolStripDropDownButton1"
        '
        'FrmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 369)
        Me.Controls.Add(Me.WebControl1)
        Me.Controls.Add(Me.AddressBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AddressBar)
        Me.Name = "FrmBrowser"
        Me.Text = "FrmBrowser"
        Me.AddressBar.ResumeLayout(False)
        Me.AddressBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddressBar As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnForward As ToolStripButton
    Friend WithEvents btnSecure As ToolStripDropDownButton
    Friend WithEvents tbAddressBox As ToolStripTextBox
    Friend WithEvents btnFavourites As ToolStripButton
    Friend WithEvents btnReload As ToolStripButton
    Friend WithEvents btnSearchProvider As ToolStripDropDownButton
    Friend WithEvents tbSearchBox As ToolStripTextBox
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents btnHome As ToolStripButton
    Friend WithEvents btnMenu As ToolStripDropDownButton
    Friend WithEvents AddressBox1 As Awesomium.Windows.Forms.AddressBox
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents webSession As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents VS2012LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2012LightTheme
End Class
