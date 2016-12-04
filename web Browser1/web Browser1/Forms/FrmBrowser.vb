Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports WeifenLuo.WinFormsUI.Docking

Namespace web_Browser1.Forms
    Partial Public Class FrmBrowser
        Inherits DockContent

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub FrmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBrowser))
            Me.AddressBar = New System.Windows.Forms.ToolStrip()
            Me.btnBack = New System.Windows.Forms.ToolStripButton()
            Me.btnForward = New System.Windows.Forms.ToolStripButton()
            Me.btnSecure = New System.Windows.Forms.ToolStripDropDownButton()
            Me.tbAddressBox = New System.Windows.Forms.ToolStripTextBox()
            Me.btnFavourites = New System.Windows.Forms.ToolStripButton()
            Me.btnReload = New System.Windows.Forms.ToolStripButton()
            Me.btnSearchprovider = New System.Windows.Forms.ToolStripDropDownButton()
            Me.tbSearchBox = New System.Windows.Forms.ToolStripTextBox()
            Me.btnSearch = New System.Windows.Forms.ToolStripButton()
            Me.btnHome = New System.Windows.Forms.ToolStripButton()
            Me.btnMenu = New System.Windows.Forms.ToolStripDropDownButton()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.AddressBox1 = New Awesomium.Windows.Forms.AddressBox()
            Me.VS2012LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2012LightTheme()
            Me.AddressBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'AddressBar
            '
            Me.AddressBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnForward, Me.btnSecure, Me.tbAddressBox, Me.btnFavourites, Me.btnReload, Me.btnSearchprovider, Me.tbSearchBox, Me.btnSearch, Me.btnHome, Me.btnMenu})
            Me.AddressBar.Location = New System.Drawing.Point(0, 0)
            Me.AddressBar.Name = "AddressBar"
            Me.AddressBar.Size = New System.Drawing.Size(581, 25)
            Me.AddressBar.TabIndex = 0
            Me.AddressBar.Text = "ToolStrip1"
            '
            'btnBack
            '
            Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
            Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(23, 22)
            Me.btnBack.Text = "ToolStripButton1"
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
            'btnSearchprovider
            '
            Me.btnSearchprovider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnSearchprovider.Image = CType(resources.GetObject("btnSearchprovider.Image"), System.Drawing.Image)
            Me.btnSearchprovider.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnSearchprovider.Name = "btnSearchprovider"
            Me.btnSearchprovider.Size = New System.Drawing.Size(29, 22)
            Me.btnSearchprovider.Text = "ToolStripDropDownButton2"
            '
            'tbSearchBox
            '
            Me.tbSearchBox.Name = "tbSearchBox"
            Me.tbSearchBox.Size = New System.Drawing.Size(100, 25)
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
            Me.btnHome.Text = "ToolStripButton1"
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
            'StatusStrip1
            '
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 380)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(581, 22)
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
            Me.AddressBox1.Size = New System.Drawing.Size(581, 20)
            Me.AddressBox1.TabIndex = 2
            Me.AddressBox1.URL = Nothing
            Me.AddressBox1.WebControl = Nothing
            '
            'FrmBrowser
            '
            Me.ClientSize = New System.Drawing.Size(581, 402)
            Me.Controls.Add(Me.AddressBox1)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.AddressBar)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.Name = "FrmBrowser"
            Me.AddressBar.ResumeLayout(False)
            Me.AddressBar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents AddressBar As ToolStrip
        Friend WithEvents btnBack As ToolStripButton
        Friend WithEvents btnForward As ToolStripButton
        Friend WithEvents btnSecure As ToolStripDropDownButton
        Friend WithEvents tbAddressBox As ToolStripTextBox
        Friend WithEvents btnFavourites As ToolStripButton
        Friend WithEvents btnReload As ToolStripButton
        Friend WithEvents btnSearchprovider As ToolStripDropDownButton
        Friend WithEvents tbSearchBox As ToolStripTextBox
        Friend WithEvents btnSearch As ToolStripButton
        Friend WithEvents btnHome As ToolStripButton
        Friend WithEvents btnMenu As ToolStripDropDownButton
        Friend WithEvents StatusStrip1 As StatusStrip
        Friend WithEvents AddressBox1 As Awesomium.Windows.Forms.AddressBox
        Friend WithEvents VS2012LightTheme1 As VS2012LightTheme

        Private Sub FrmBrowser_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace