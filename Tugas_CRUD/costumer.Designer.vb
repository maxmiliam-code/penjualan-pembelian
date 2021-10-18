<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class costumer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.dgv_cos = New System.Windows.Forms.DataGridView()
        Me.bt_delcos = New System.Windows.Forms.Button()
        Me.bt_backcos = New System.Windows.Forms.Button()
        Me.bt_upcos = New System.Windows.Forms.Button()
        Me.bt_tambahcos = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_telponcos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_alamatcos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_namacos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_kodecos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_cos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Search"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(438, 179)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 60
        '
        'dgv_cos
        '
        Me.dgv_cos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cos.Location = New System.Drawing.Point(37, 208)
        Me.dgv_cos.Name = "dgv_cos"
        Me.dgv_cos.Size = New System.Drawing.Size(501, 150)
        Me.dgv_cos.TabIndex = 59
        '
        'bt_delcos
        '
        Me.bt_delcos.Location = New System.Drawing.Point(221, 179)
        Me.bt_delcos.Name = "bt_delcos"
        Me.bt_delcos.Size = New System.Drawing.Size(75, 23)
        Me.bt_delcos.TabIndex = 58
        Me.bt_delcos.Text = "Delete"
        Me.bt_delcos.UseVisualStyleBackColor = True
        '
        'bt_backcos
        '
        Me.bt_backcos.Location = New System.Drawing.Point(310, 179)
        Me.bt_backcos.Name = "bt_backcos"
        Me.bt_backcos.Size = New System.Drawing.Size(75, 23)
        Me.bt_backcos.TabIndex = 57
        Me.bt_backcos.Text = "Back"
        Me.bt_backcos.UseVisualStyleBackColor = True
        '
        'bt_upcos
        '
        Me.bt_upcos.Location = New System.Drawing.Point(125, 179)
        Me.bt_upcos.Name = "bt_upcos"
        Me.bt_upcos.Size = New System.Drawing.Size(75, 23)
        Me.bt_upcos.TabIndex = 56
        Me.bt_upcos.Text = "Update"
        Me.bt_upcos.UseVisualStyleBackColor = True
        '
        'bt_tambahcos
        '
        Me.bt_tambahcos.Location = New System.Drawing.Point(37, 179)
        Me.bt_tambahcos.Name = "bt_tambahcos"
        Me.bt_tambahcos.Size = New System.Drawing.Size(75, 23)
        Me.bt_tambahcos.TabIndex = 55
        Me.bt_tambahcos.Text = "Tambah"
        Me.bt_tambahcos.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "No HP / Telepon"
        '
        'tb_telponcos
        '
        Me.tb_telponcos.Location = New System.Drawing.Point(142, 153)
        Me.tb_telponcos.Name = "tb_telponcos"
        Me.tb_telponcos.Size = New System.Drawing.Size(277, 20)
        Me.tb_telponcos.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Alamat"
        '
        'tb_alamatcos
        '
        Me.tb_alamatcos.Location = New System.Drawing.Point(142, 121)
        Me.tb_alamatcos.Name = "tb_alamatcos"
        Me.tb_alamatcos.Size = New System.Drawing.Size(277, 20)
        Me.tb_alamatcos.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Nama Costumer"
        '
        'tb_namacos
        '
        Me.tb_namacos.Location = New System.Drawing.Point(142, 91)
        Me.tb_namacos.Name = "tb_namacos"
        Me.tb_namacos.Size = New System.Drawing.Size(277, 20)
        Me.tb_namacos.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Kode Costumer"
        '
        'tb_kodecos
        '
        Me.tb_kodecos.Location = New System.Drawing.Point(142, 58)
        Me.tb_kodecos.Name = "tb_kodecos"
        Me.tb_kodecos.Size = New System.Drawing.Size(100, 20)
        Me.tb_kodecos.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Form Costumer"
        '
        'costumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 369)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.dgv_cos)
        Me.Controls.Add(Me.bt_delcos)
        Me.Controls.Add(Me.bt_backcos)
        Me.Controls.Add(Me.bt_upcos)
        Me.Controls.Add(Me.bt_tambahcos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_telponcos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_alamatcos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_namacos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_kodecos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "costumer"
        Me.Text = "costumer"
        CType(Me.dgv_cos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents dgv_cos As Windows.Forms.DataGridView
    Friend WithEvents bt_delcos As Windows.Forms.Button
    Friend WithEvents bt_backcos As Windows.Forms.Button
    Friend WithEvents bt_upcos As Windows.Forms.Button
    Friend WithEvents bt_tambahcos As Windows.Forms.Button
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents tb_telponcos As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents tb_alamatcos As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents tb_namacos As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents tb_kodecos As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
