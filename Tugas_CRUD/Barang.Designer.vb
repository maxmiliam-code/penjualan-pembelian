<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_hrgjual = New System.Windows.Forms.TextBox()
        Me.bt_deletebrg = New System.Windows.Forms.Button()
        Me.bt_backbrg = New System.Windows.Forms.Button()
        Me.bt_updatebrg = New System.Windows.Forms.Button()
        Me.bt_tambahbrg = New System.Windows.Forms.Button()
        Me.dgv_brg = New System.Windows.Forms.DataGridView()
        Me.cb_satuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_stok = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_namabrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_kodebrg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_hrgbeli = New System.Windows.Forms.TextBox()
        CType(Me.dgv_brg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(412, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Search"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(469, 163)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Harga Jual"
        '
        'tb_hrgjual
        '
        Me.tb_hrgjual.Location = New System.Drawing.Point(469, 92)
        Me.tb_hrgjual.Name = "tb_hrgjual"
        Me.tb_hrgjual.Size = New System.Drawing.Size(100, 20)
        Me.tb_hrgjual.TabIndex = 33
        '
        'bt_deletebrg
        '
        Me.bt_deletebrg.Location = New System.Drawing.Point(222, 161)
        Me.bt_deletebrg.Name = "bt_deletebrg"
        Me.bt_deletebrg.Size = New System.Drawing.Size(75, 23)
        Me.bt_deletebrg.TabIndex = 32
        Me.bt_deletebrg.Text = "Delete"
        Me.bt_deletebrg.UseVisualStyleBackColor = True
        '
        'bt_backbrg
        '
        Me.bt_backbrg.Location = New System.Drawing.Point(316, 161)
        Me.bt_backbrg.Name = "bt_backbrg"
        Me.bt_backbrg.Size = New System.Drawing.Size(75, 23)
        Me.bt_backbrg.TabIndex = 31
        Me.bt_backbrg.Text = "Back"
        Me.bt_backbrg.UseVisualStyleBackColor = True
        '
        'bt_updatebrg
        '
        Me.bt_updatebrg.Location = New System.Drawing.Point(126, 161)
        Me.bt_updatebrg.Name = "bt_updatebrg"
        Me.bt_updatebrg.Size = New System.Drawing.Size(75, 23)
        Me.bt_updatebrg.TabIndex = 30
        Me.bt_updatebrg.Text = "Update"
        Me.bt_updatebrg.UseVisualStyleBackColor = True
        '
        'bt_tambahbrg
        '
        Me.bt_tambahbrg.Location = New System.Drawing.Point(38, 161)
        Me.bt_tambahbrg.Name = "bt_tambahbrg"
        Me.bt_tambahbrg.Size = New System.Drawing.Size(75, 23)
        Me.bt_tambahbrg.TabIndex = 29
        Me.bt_tambahbrg.Text = "Tambah"
        Me.bt_tambahbrg.UseVisualStyleBackColor = True
        '
        'dgv_brg
        '
        Me.dgv_brg.AllowUserToAddRows = False
        Me.dgv_brg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_brg.Location = New System.Drawing.Point(36, 199)
        Me.dgv_brg.Name = "dgv_brg"
        Me.dgv_brg.ReadOnly = True
        Me.dgv_brg.Size = New System.Drawing.Size(543, 154)
        Me.dgv_brg.TabIndex = 28
        '
        'cb_satuan
        '
        Me.cb_satuan.FormattingEnabled = True
        Me.cb_satuan.Items.AddRange(New Object() {"Pcs", "Kg"})
        Me.cb_satuan.Location = New System.Drawing.Point(126, 127)
        Me.cb_satuan.Name = "cb_satuan"
        Me.cb_satuan.Size = New System.Drawing.Size(121, 21)
        Me.cb_satuan.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Satuan"
        '
        'tb_stok
        '
        Me.tb_stok.Location = New System.Drawing.Point(299, 130)
        Me.tb_stok.Name = "tb_stok"
        Me.tb_stok.Size = New System.Drawing.Size(100, 20)
        Me.tb_stok.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Barang"
        '
        'tb_namabrg
        '
        Me.tb_namabrg.Location = New System.Drawing.Point(126, 92)
        Me.tb_namabrg.Name = "tb_namabrg"
        Me.tb_namabrg.Size = New System.Drawing.Size(273, 20)
        Me.tb_namabrg.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Kode Barang"
        '
        'tb_kodebrg
        '
        Me.tb_kodebrg.Location = New System.Drawing.Point(126, 56)
        Me.tb_kodebrg.Name = "tb_kodebrg"
        Me.tb_kodebrg.Size = New System.Drawing.Size(100, 20)
        Me.tb_kodebrg.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Form Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Harga Beli"
        '
        'tb_hrgbeli
        '
        Me.tb_hrgbeli.Location = New System.Drawing.Point(469, 130)
        Me.tb_hrgbeli.Name = "tb_hrgbeli"
        Me.tb_hrgbeli.Size = New System.Drawing.Size(100, 20)
        Me.tb_hrgbeli.TabIndex = 37
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 361)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_hrgbeli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_hrgjual)
        Me.Controls.Add(Me.bt_deletebrg)
        Me.Controls.Add(Me.bt_backbrg)
        Me.Controls.Add(Me.bt_updatebrg)
        Me.Controls.Add(Me.bt_tambahbrg)
        Me.Controls.Add(Me.dgv_brg)
        Me.Controls.Add(Me.cb_satuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_stok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_namabrg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_kodebrg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.dgv_brg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents tb_hrgjual As Windows.Forms.TextBox
    Friend WithEvents bt_deletebrg As Windows.Forms.Button
    Friend WithEvents bt_backbrg As Windows.Forms.Button
    Friend WithEvents bt_updatebrg As Windows.Forms.Button
    Friend WithEvents bt_tambahbrg As Windows.Forms.Button
    Friend WithEvents dgv_brg As Windows.Forms.DataGridView
    Friend WithEvents cb_satuan As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents tb_stok As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents tb_namabrg As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents tb_kodebrg As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents tb_hrgbeli As Windows.Forms.TextBox
End Class
