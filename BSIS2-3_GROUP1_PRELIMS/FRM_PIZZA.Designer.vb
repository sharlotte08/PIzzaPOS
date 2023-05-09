<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PIZZA
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
        Me.BTNPRINT = New System.Windows.Forms.Button()
        Me.TXTTOTALORDER = New System.Windows.Forms.TextBox()
        Me.TXTDCHARGE = New System.Windows.Forms.TextBox()
        Me.TXTYORDER = New System.Windows.Forms.TextBox()
        Me.LBLTOTALORDER = New System.Windows.Forms.Label()
        Me.LBLDCHARGE = New System.Windows.Forms.Label()
        Me.LBLORDER = New System.Windows.Forms.Label()
        Me.GBADD = New System.Windows.Forms.GroupBox()
        Me.BTNPROCESS = New System.Windows.Forms.Button()
        Me.GBEXTRA = New System.Windows.Forms.GroupBox()
        Me.CHKPEPPERONI = New System.Windows.Forms.CheckBox()
        Me.CHKHAM = New System.Windows.Forms.CheckBox()
        Me.CHKGPEPPERS = New System.Windows.Forms.CheckBox()
        Me.CHKCHEESE = New System.Windows.Forms.CheckBox()
        Me.GBBASE = New System.Windows.Forms.GroupBox()
        Me.RBT15 = New System.Windows.Forms.RadioButton()
        Me.RBT12 = New System.Windows.Forms.RadioButton()
        Me.RBT10 = New System.Windows.Forms.RadioButton()
        Me.RBT8 = New System.Windows.Forms.RadioButton()
        Me.GBORDER = New System.Windows.Forms.GroupBox()
        Me.GBPITCHA = New System.Windows.Forms.GroupBox()
        Me.RBTHPINEAPP = New System.Windows.Forms.RadioButton()
        Me.RBTHCCLASS = New System.Windows.Forms.RadioButton()
        Me.RBTPCLASS = New System.Windows.Forms.RadioButton()
        Me.RBTCCLASS = New System.Windows.Forms.RadioButton()
        Me.RBTHAWAIIAN = New System.Windows.Forms.RadioButton()
        Me.GBCUSTOMER = New System.Windows.Forms.GroupBox()
        Me.TXTCONTACT = New System.Windows.Forms.TextBox()
        Me.TXTCADD = New System.Windows.Forms.TextBox()
        Me.TXTCNAME = New System.Windows.Forms.TextBox()
        Me.LBLCONTACT = New System.Windows.Forms.Label()
        Me.LBLCADD = New System.Windows.Forms.Label()
        Me.LBLCNAME = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTNOTE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBADD.SuspendLayout()
        Me.GBEXTRA.SuspendLayout()
        Me.GBBASE.SuspendLayout()
        Me.GBORDER.SuspendLayout()
        Me.GBPITCHA.SuspendLayout()
        Me.GBCUSTOMER.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNPRINT
        '
        Me.BTNPRINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPRINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRINT.Location = New System.Drawing.Point(608, 578)
        Me.BTNPRINT.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.Size = New System.Drawing.Size(133, 32)
        Me.BTNPRINT.TabIndex = 11
        Me.BTNPRINT.Text = "PRINT ORDER"
        Me.BTNPRINT.UseVisualStyleBackColor = False
        '
        'TXTTOTALORDER
        '
        Me.TXTTOTALORDER.Location = New System.Drawing.Point(608, 544)
        Me.TXTTOTALORDER.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTTOTALORDER.Name = "TXTTOTALORDER"
        Me.TXTTOTALORDER.ReadOnly = True
        Me.TXTTOTALORDER.Size = New System.Drawing.Size(132, 22)
        Me.TXTTOTALORDER.TabIndex = 20
        Me.TXTTOTALORDER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTDCHARGE
        '
        Me.TXTDCHARGE.Location = New System.Drawing.Point(608, 512)
        Me.TXTDCHARGE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTDCHARGE.Name = "TXTDCHARGE"
        Me.TXTDCHARGE.ReadOnly = True
        Me.TXTDCHARGE.Size = New System.Drawing.Size(132, 22)
        Me.TXTDCHARGE.TabIndex = 19
        Me.TXTDCHARGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTYORDER
        '
        Me.TXTYORDER.Location = New System.Drawing.Point(608, 480)
        Me.TXTYORDER.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTYORDER.Name = "TXTYORDER"
        Me.TXTYORDER.ReadOnly = True
        Me.TXTYORDER.Size = New System.Drawing.Size(132, 22)
        Me.TXTYORDER.TabIndex = 18
        Me.TXTYORDER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLTOTALORDER
        '
        Me.LBLTOTALORDER.AutoSize = True
        Me.LBLTOTALORDER.BackColor = System.Drawing.Color.Transparent
        Me.LBLTOTALORDER.ForeColor = System.Drawing.Color.White
        Me.LBLTOTALORDER.Location = New System.Drawing.Point(483, 551)
        Me.LBLTOTALORDER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLTOTALORDER.Name = "LBLTOTALORDER"
        Me.LBLTOTALORDER.Size = New System.Drawing.Size(108, 17)
        Me.LBLTOTALORDER.TabIndex = 23
        Me.LBLTOTALORDER.Text = "TOTAL ORDER"
        '
        'LBLDCHARGE
        '
        Me.LBLDCHARGE.AutoSize = True
        Me.LBLDCHARGE.BackColor = System.Drawing.Color.Transparent
        Me.LBLDCHARGE.ForeColor = System.Drawing.Color.White
        Me.LBLDCHARGE.Location = New System.Drawing.Point(452, 519)
        Me.LBLDCHARGE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLDCHARGE.Name = "LBLDCHARGE"
        Me.LBLDCHARGE.Size = New System.Drawing.Size(137, 17)
        Me.LBLDCHARGE.TabIndex = 24
        Me.LBLDCHARGE.Text = "DELIVERY CHARGE"
        '
        'LBLORDER
        '
        Me.LBLORDER.AutoSize = True
        Me.LBLORDER.BackColor = System.Drawing.Color.Transparent
        Me.LBLORDER.ForeColor = System.Drawing.Color.White
        Me.LBLORDER.Location = New System.Drawing.Point(489, 487)
        Me.LBLORDER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLORDER.Name = "LBLORDER"
        Me.LBLORDER.Size = New System.Drawing.Size(102, 17)
        Me.LBLORDER.TabIndex = 25
        Me.LBLORDER.Text = "YOUR ORDER"
        '
        'GBADD
        '
        Me.GBADD.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBADD.Controls.Add(Me.BTNPROCESS)
        Me.GBADD.Controls.Add(Me.GBEXTRA)
        Me.GBADD.Controls.Add(Me.GBBASE)
        Me.GBADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBADD.ForeColor = System.Drawing.Color.White
        Me.GBADD.Location = New System.Drawing.Point(384, 187)
        Me.GBADD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBADD.Name = "GBADD"
        Me.GBADD.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBADD.Size = New System.Drawing.Size(367, 260)
        Me.GBADD.TabIndex = 22
        Me.GBADD.TabStop = False
        Me.GBADD.Text = "ADDITIONAL"
        '
        'BTNPROCESS
        '
        Me.BTNPROCESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPROCESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPROCESS.Location = New System.Drawing.Point(19, 208)
        Me.BTNPROCESS.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BTNPROCESS.Name = "BTNPROCESS"
        Me.BTNPROCESS.Size = New System.Drawing.Size(323, 42)
        Me.BTNPROCESS.TabIndex = 17
        Me.BTNPROCESS.Text = "PROCESS ORDER"
        Me.BTNPROCESS.UseVisualStyleBackColor = True
        '
        'GBEXTRA
        '
        Me.GBEXTRA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBEXTRA.Controls.Add(Me.CHKPEPPERONI)
        Me.GBEXTRA.Controls.Add(Me.CHKHAM)
        Me.GBEXTRA.Controls.Add(Me.CHKGPEPPERS)
        Me.GBEXTRA.Controls.Add(Me.CHKCHEESE)
        Me.GBEXTRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEXTRA.ForeColor = System.Drawing.Color.Black
        Me.GBEXTRA.Location = New System.Drawing.Point(137, 34)
        Me.GBEXTRA.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBEXTRA.Name = "GBEXTRA"
        Me.GBEXTRA.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBEXTRA.Size = New System.Drawing.Size(204, 170)
        Me.GBEXTRA.TabIndex = 9
        Me.GBEXTRA.TabStop = False
        Me.GBEXTRA.Text = "Extra"
        '
        'CHKPEPPERONI
        '
        Me.CHKPEPPERONI.AutoSize = True
        Me.CHKPEPPERONI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKPEPPERONI.ForeColor = System.Drawing.Color.Black
        Me.CHKPEPPERONI.Location = New System.Drawing.Point(25, 116)
        Me.CHKPEPPERONI.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CHKPEPPERONI.Name = "CHKPEPPERONI"
        Me.CHKPEPPERONI.Size = New System.Drawing.Size(115, 24)
        Me.CHKPEPPERONI.TabIndex = 16
        Me.CHKPEPPERONI.Text = "Pepperoni"
        Me.CHKPEPPERONI.UseVisualStyleBackColor = True
        '
        'CHKHAM
        '
        Me.CHKHAM.AutoSize = True
        Me.CHKHAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKHAM.ForeColor = System.Drawing.Color.Black
        Me.CHKHAM.Location = New System.Drawing.Point(25, 86)
        Me.CHKHAM.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CHKHAM.Name = "CHKHAM"
        Me.CHKHAM.Size = New System.Drawing.Size(70, 24)
        Me.CHKHAM.TabIndex = 15
        Me.CHKHAM.Text = "Ham"
        Me.CHKHAM.UseVisualStyleBackColor = True
        '
        'CHKGPEPPERS
        '
        Me.CHKGPEPPERS.AutoSize = True
        Me.CHKGPEPPERS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKGPEPPERS.ForeColor = System.Drawing.Color.Black
        Me.CHKGPEPPERS.Location = New System.Drawing.Point(25, 57)
        Me.CHKGPEPPERS.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CHKGPEPPERS.Name = "CHKGPEPPERS"
        Me.CHKGPEPPERS.Size = New System.Drawing.Size(157, 24)
        Me.CHKGPEPPERS.TabIndex = 14
        Me.CHKGPEPPERS.Text = "Green Peppers"
        Me.CHKGPEPPERS.UseVisualStyleBackColor = True
        '
        'CHKCHEESE
        '
        Me.CHKCHEESE.AutoSize = True
        Me.CHKCHEESE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCHEESE.ForeColor = System.Drawing.Color.Black
        Me.CHKCHEESE.Location = New System.Drawing.Point(25, 32)
        Me.CHKCHEESE.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CHKCHEESE.Name = "CHKCHEESE"
        Me.CHKCHEESE.Size = New System.Drawing.Size(94, 24)
        Me.CHKCHEESE.TabIndex = 13
        Me.CHKCHEESE.Text = "Cheese"
        Me.CHKCHEESE.UseVisualStyleBackColor = True
        '
        'GBBASE
        '
        Me.GBBASE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBBASE.Controls.Add(Me.RBT15)
        Me.GBBASE.Controls.Add(Me.RBT12)
        Me.GBBASE.Controls.Add(Me.RBT10)
        Me.GBBASE.Controls.Add(Me.RBT8)
        Me.GBBASE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBBASE.ForeColor = System.Drawing.Color.Black
        Me.GBBASE.Location = New System.Drawing.Point(19, 34)
        Me.GBBASE.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBBASE.Name = "GBBASE"
        Me.GBBASE.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBBASE.Size = New System.Drawing.Size(115, 170)
        Me.GBBASE.TabIndex = 8
        Me.GBBASE.TabStop = False
        Me.GBBASE.Text = "Base"
        '
        'RBT15
        '
        Me.RBT15.AutoSize = True
        Me.RBT15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBT15.ForeColor = System.Drawing.Color.Black
        Me.RBT15.Location = New System.Drawing.Point(23, 116)
        Me.RBT15.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBT15.Name = "RBT15"
        Me.RBT15.Size = New System.Drawing.Size(57, 24)
        Me.RBT15.TabIndex = 12
        Me.RBT15.TabStop = True
        Me.RBT15.Text = "15"""
        Me.RBT15.UseVisualStyleBackColor = True
        '
        'RBT12
        '
        Me.RBT12.AutoSize = True
        Me.RBT12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBT12.ForeColor = System.Drawing.Color.Black
        Me.RBT12.Location = New System.Drawing.Point(23, 86)
        Me.RBT12.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBT12.Name = "RBT12"
        Me.RBT12.Size = New System.Drawing.Size(57, 24)
        Me.RBT12.TabIndex = 11
        Me.RBT12.TabStop = True
        Me.RBT12.Text = "12"""
        Me.RBT12.UseVisualStyleBackColor = True
        '
        'RBT10
        '
        Me.RBT10.AutoSize = True
        Me.RBT10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBT10.ForeColor = System.Drawing.Color.Black
        Me.RBT10.Location = New System.Drawing.Point(23, 57)
        Me.RBT10.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBT10.Name = "RBT10"
        Me.RBT10.Size = New System.Drawing.Size(57, 24)
        Me.RBT10.TabIndex = 10
        Me.RBT10.TabStop = True
        Me.RBT10.Text = "10"""
        Me.RBT10.UseVisualStyleBackColor = True
        '
        'RBT8
        '
        Me.RBT8.AutoSize = True
        Me.RBT8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBT8.ForeColor = System.Drawing.Color.Black
        Me.RBT8.Location = New System.Drawing.Point(23, 32)
        Me.RBT8.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBT8.Name = "RBT8"
        Me.RBT8.Size = New System.Drawing.Size(47, 24)
        Me.RBT8.TabIndex = 9
        Me.RBT8.TabStop = True
        Me.RBT8.Text = "8"""
        Me.RBT8.UseVisualStyleBackColor = True
        '
        'GBORDER
        '
        Me.GBORDER.BackColor = System.Drawing.Color.DarkKhaki
        Me.GBORDER.Controls.Add(Me.GBPITCHA)
        Me.GBORDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBORDER.ForeColor = System.Drawing.Color.White
        Me.GBORDER.Location = New System.Drawing.Point(73, 187)
        Me.GBORDER.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBORDER.Name = "GBORDER"
        Me.GBORDER.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBORDER.Size = New System.Drawing.Size(304, 260)
        Me.GBORDER.TabIndex = 21
        Me.GBORDER.TabStop = False
        Me.GBORDER.Text = "Order"
        '
        'GBPITCHA
        '
        Me.GBPITCHA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBPITCHA.Controls.Add(Me.RBTHPINEAPP)
        Me.GBPITCHA.Controls.Add(Me.RBTHCCLASS)
        Me.GBPITCHA.Controls.Add(Me.RBTPCLASS)
        Me.GBPITCHA.Controls.Add(Me.RBTCCLASS)
        Me.GBPITCHA.Controls.Add(Me.RBTHAWAIIAN)
        Me.GBPITCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPITCHA.ForeColor = System.Drawing.Color.SeaGreen
        Me.GBPITCHA.Location = New System.Drawing.Point(21, 32)
        Me.GBPITCHA.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBPITCHA.Name = "GBPITCHA"
        Me.GBPITCHA.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBPITCHA.Size = New System.Drawing.Size(263, 204)
        Me.GBPITCHA.TabIndex = 4
        Me.GBPITCHA.TabStop = False
        Me.GBPITCHA.Text = "Pitchapie"
        '
        'RBTHPINEAPP
        '
        Me.RBTHPINEAPP.AutoSize = True
        Me.RBTHPINEAPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTHPINEAPP.ForeColor = System.Drawing.Color.Black
        Me.RBTHPINEAPP.Location = New System.Drawing.Point(20, 155)
        Me.RBTHPINEAPP.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBTHPINEAPP.Name = "RBTHPINEAPP"
        Me.RBTHPINEAPP.Size = New System.Drawing.Size(157, 24)
        Me.RBTHPINEAPP.TabIndex = 8
        Me.RBTHPINEAPP.TabStop = True
        Me.RBTHPINEAPP.Text = "Ham Pineapple"
        Me.RBTHPINEAPP.UseVisualStyleBackColor = True
        '
        'RBTHCCLASS
        '
        Me.RBTHCCLASS.AutoSize = True
        Me.RBTHCCLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTHCCLASS.ForeColor = System.Drawing.Color.Black
        Me.RBTHCCLASS.Location = New System.Drawing.Point(20, 123)
        Me.RBTHCCLASS.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBTHCCLASS.Name = "RBTHCCLASS"
        Me.RBTHCCLASS.Size = New System.Drawing.Size(207, 24)
        Me.RBTHCCLASS.TabIndex = 7
        Me.RBTHCCLASS.TabStop = True
        Me.RBTHCCLASS.Text = "Ham Cheese Classic"
        Me.RBTHCCLASS.UseVisualStyleBackColor = True
        '
        'RBTPCLASS
        '
        Me.RBTPCLASS.AutoSize = True
        Me.RBTPCLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTPCLASS.ForeColor = System.Drawing.Color.Black
        Me.RBTPCLASS.Location = New System.Drawing.Point(20, 94)
        Me.RBTPCLASS.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBTPCLASS.Name = "RBTPCLASS"
        Me.RBTPCLASS.Size = New System.Drawing.Size(183, 24)
        Me.RBTPCLASS.TabIndex = 6
        Me.RBTPCLASS.TabStop = True
        Me.RBTPCLASS.Text = "Pepperoni Classic"
        Me.RBTPCLASS.UseVisualStyleBackColor = True
        '
        'RBTCCLASS
        '
        Me.RBTCCLASS.AutoSize = True
        Me.RBTCCLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTCCLASS.ForeColor = System.Drawing.Color.Black
        Me.RBTCCLASS.Location = New System.Drawing.Point(20, 64)
        Me.RBTCCLASS.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBTCCLASS.Name = "RBTCCLASS"
        Me.RBTCCLASS.Size = New System.Drawing.Size(162, 24)
        Me.RBTCCLASS.TabIndex = 5
        Me.RBTCCLASS.TabStop = True
        Me.RBTCCLASS.Text = "Cheese Classic"
        Me.RBTCCLASS.UseVisualStyleBackColor = True
        '
        'RBTHAWAIIAN
        '
        Me.RBTHAWAIIAN.AutoSize = True
        Me.RBTHAWAIIAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTHAWAIIAN.ForeColor = System.Drawing.Color.Black
        Me.RBTHAWAIIAN.Location = New System.Drawing.Point(20, 34)
        Me.RBTHAWAIIAN.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RBTHAWAIIAN.Name = "RBTHAWAIIAN"
        Me.RBTHAWAIIAN.Size = New System.Drawing.Size(107, 24)
        Me.RBTHAWAIIAN.TabIndex = 4
        Me.RBTHAWAIIAN.TabStop = True
        Me.RBTHAWAIIAN.Text = "Hawaiian"
        Me.RBTHAWAIIAN.UseVisualStyleBackColor = True
        '
        'GBCUSTOMER
        '
        Me.GBCUSTOMER.BackColor = System.Drawing.Color.Transparent
        Me.GBCUSTOMER.Controls.Add(Me.TXTCONTACT)
        Me.GBCUSTOMER.Controls.Add(Me.TXTCADD)
        Me.GBCUSTOMER.Controls.Add(Me.TXTCNAME)
        Me.GBCUSTOMER.Controls.Add(Me.LBLCONTACT)
        Me.GBCUSTOMER.Controls.Add(Me.LBLCADD)
        Me.GBCUSTOMER.Controls.Add(Me.LBLCNAME)
        Me.GBCUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCUSTOMER.ForeColor = System.Drawing.Color.White
        Me.GBCUSTOMER.Location = New System.Drawing.Point(27, 46)
        Me.GBCUSTOMER.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBCUSTOMER.Name = "GBCUSTOMER"
        Me.GBCUSTOMER.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GBCUSTOMER.Size = New System.Drawing.Size(492, 124)
        Me.GBCUSTOMER.TabIndex = 20
        Me.GBCUSTOMER.TabStop = False
        Me.GBCUSTOMER.Text = "Costumer Details"
        '
        'TXTCONTACT
        '
        Me.TXTCONTACT.Location = New System.Drawing.Point(183, 80)
        Me.TXTCONTACT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXTCONTACT.Name = "TXTCONTACT"
        Me.TXTCONTACT.Size = New System.Drawing.Size(291, 27)
        Me.TXTCONTACT.TabIndex = 3
        Me.TXTCONTACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCADD
        '
        Me.TXTCADD.Location = New System.Drawing.Point(183, 49)
        Me.TXTCADD.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXTCADD.Name = "TXTCADD"
        Me.TXTCADD.Size = New System.Drawing.Size(291, 27)
        Me.TXTCADD.TabIndex = 2
        Me.TXTCADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTCNAME
        '
        Me.TXTCNAME.Location = New System.Drawing.Point(183, 18)
        Me.TXTCNAME.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TXTCNAME.Name = "TXTCNAME"
        Me.TXTCNAME.Size = New System.Drawing.Size(291, 27)
        Me.TXTCNAME.TabIndex = 1
        Me.TXTCNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLCONTACT
        '
        Me.LBLCONTACT.AutoSize = True
        Me.LBLCONTACT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCONTACT.ForeColor = System.Drawing.Color.White
        Me.LBLCONTACT.Location = New System.Drawing.Point(8, 86)
        Me.LBLCONTACT.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLCONTACT.Name = "LBLCONTACT"
        Me.LBLCONTACT.Size = New System.Drawing.Size(150, 20)
        Me.LBLCONTACT.TabIndex = 0
        Me.LBLCONTACT.Text = "Customer Contact:"
        '
        'LBLCADD
        '
        Me.LBLCADD.AutoSize = True
        Me.LBLCADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCADD.ForeColor = System.Drawing.Color.White
        Me.LBLCADD.Location = New System.Drawing.Point(8, 57)
        Me.LBLCADD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLCADD.Name = "LBLCADD"
        Me.LBLCADD.Size = New System.Drawing.Size(154, 20)
        Me.LBLCADD.TabIndex = 0
        Me.LBLCADD.Text = "Customer Address:"
        '
        'LBLCNAME
        '
        Me.LBLCNAME.AutoSize = True
        Me.LBLCNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCNAME.ForeColor = System.Drawing.Color.White
        Me.LBLCNAME.Location = New System.Drawing.Point(8, 26)
        Me.LBLCNAME.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLCNAME.Name = "LBLCNAME"
        Me.LBLCNAME.Size = New System.Drawing.Size(136, 20)
        Me.LBLCNAME.TabIndex = 0
        Me.LBLCNAME.Text = "Customer Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Prelim_Pizza.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(537, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'TXTNOTE
        '
        Me.TXTNOTE.Location = New System.Drawing.Point(27, 502)
        Me.TXTNOTE.Multiline = True
        Me.TXTNOTE.Name = "TXTNOTE"
        Me.TXTNOTE.Size = New System.Drawing.Size(418, 117)
        Me.TXTNOTE.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(28, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 51)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "  additional note/instructions upon delivery:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_PIZZA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Prelim_Pizza.My.Resources.Resources.Untitled_design
        Me.ClientSize = New System.Drawing.Size(839, 645)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNOTE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNPRINT)
        Me.Controls.Add(Me.TXTTOTALORDER)
        Me.Controls.Add(Me.TXTDCHARGE)
        Me.Controls.Add(Me.TXTYORDER)
        Me.Controls.Add(Me.LBLTOTALORDER)
        Me.Controls.Add(Me.LBLDCHARGE)
        Me.Controls.Add(Me.LBLORDER)
        Me.Controls.Add(Me.GBADD)
        Me.Controls.Add(Me.GBORDER)
        Me.Controls.Add(Me.GBCUSTOMER)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PIZZA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIZZA Express"
        Me.GBADD.ResumeLayout(False)
        Me.GBEXTRA.ResumeLayout(False)
        Me.GBEXTRA.PerformLayout()
        Me.GBBASE.ResumeLayout(False)
        Me.GBBASE.PerformLayout()
        Me.GBORDER.ResumeLayout(False)
        Me.GBPITCHA.ResumeLayout(False)
        Me.GBPITCHA.PerformLayout()
        Me.GBCUSTOMER.ResumeLayout(False)
        Me.GBCUSTOMER.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNPRINT As System.Windows.Forms.Button
    Friend WithEvents TXTTOTALORDER As System.Windows.Forms.TextBox
    Friend WithEvents TXTDCHARGE As System.Windows.Forms.TextBox
    Friend WithEvents TXTYORDER As System.Windows.Forms.TextBox
    Friend WithEvents LBLTOTALORDER As System.Windows.Forms.Label
    Friend WithEvents LBLDCHARGE As System.Windows.Forms.Label
    Friend WithEvents LBLORDER As System.Windows.Forms.Label
    Friend WithEvents GBADD As System.Windows.Forms.GroupBox
    Friend WithEvents BTNPROCESS As System.Windows.Forms.Button
    Friend WithEvents GBEXTRA As System.Windows.Forms.GroupBox
    Friend WithEvents CHKPEPPERONI As System.Windows.Forms.CheckBox
    Friend WithEvents CHKHAM As System.Windows.Forms.CheckBox
    Friend WithEvents CHKGPEPPERS As System.Windows.Forms.CheckBox
    Friend WithEvents CHKCHEESE As System.Windows.Forms.CheckBox
    Friend WithEvents GBBASE As System.Windows.Forms.GroupBox
    Friend WithEvents RBT15 As System.Windows.Forms.RadioButton
    Friend WithEvents RBT12 As System.Windows.Forms.RadioButton
    Friend WithEvents RBT10 As System.Windows.Forms.RadioButton
    Friend WithEvents RBT8 As System.Windows.Forms.RadioButton
    Friend WithEvents GBORDER As System.Windows.Forms.GroupBox
    Friend WithEvents GBPITCHA As System.Windows.Forms.GroupBox
    Friend WithEvents RBTHPINEAPP As System.Windows.Forms.RadioButton
    Friend WithEvents RBTHCCLASS As System.Windows.Forms.RadioButton
    Friend WithEvents RBTPCLASS As System.Windows.Forms.RadioButton
    Friend WithEvents RBTCCLASS As System.Windows.Forms.RadioButton
    Friend WithEvents RBTHAWAIIAN As System.Windows.Forms.RadioButton
    Friend WithEvents GBCUSTOMER As System.Windows.Forms.GroupBox
    Friend WithEvents TXTCONTACT As System.Windows.Forms.TextBox
    Friend WithEvents TXTCADD As System.Windows.Forms.TextBox
    Friend WithEvents TXTCNAME As System.Windows.Forms.TextBox
    Friend WithEvents LBLCONTACT As System.Windows.Forms.Label
    Friend WithEvents LBLCADD As System.Windows.Forms.Label
    Friend WithEvents LBLCNAME As System.Windows.Forms.Label
    Friend WithEvents TXTNOTE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
