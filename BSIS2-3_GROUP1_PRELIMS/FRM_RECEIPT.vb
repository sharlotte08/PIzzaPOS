Public Class FRM_RECEIPT

    Private Sub FRM_RECEIPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LBLCNAME.Text = FRM_PIZZA.TXTCNAME.Text
        Me.LBLCADD.Text = FRM_PIZZA.TXTCADD.Text
        Me.LBLCONTACT.Text = FRM_PIZZA.TXTCONTACT.Text
        Me.LBLNOTE.Text = FRM_PIZZA.TXTNOTE.Text
        LBLDATETIME.Text = DateTime.Now.ToString()

        If FRM_PIZZA.RBTHAWAIIAN.Checked = True Then
            LBLYORDER.Text = "HAWAIIAN"
        ElseIf FRM_PIZZA.RBTCCLASS.Checked = True Then
            LBLYORDER.Text = "CHEESE CLASSIC"
        ElseIf FRM_PIZZA.RBTPCLASS.Checked = True Then
            LBLYORDER.Text = "PEPPERONI CLASSIC"
        ElseIf FRM_PIZZA.RBTHCCLASS.Checked = True Then
            LBLYORDER.Text = "HAM CHEESE CLASSIC"
        ElseIf FRM_PIZZA.RBTHPINEAPP.Checked = True Then
            LBLYORDER.Text = "HAM PINEAPPLE"
        Else
            LBLYORDER.Text = "No Order"
        End If

        If FRM_PIZZA.RBT8.Checked = True Then
            LBLBASE.Text = "8"
        ElseIf FRM_PIZZA.RBT10.Checked = True Then
            LBLBASE.Text = "10"
        ElseIf FRM_PIZZA.RBT12.Checked = True Then
            LBLBASE.Text = "12"
        ElseIf FRM_PIZZA.RBT15.Checked = True Then
            LBLBASE.Text = "15"
        Else
            LBLBASE.Text = "0"
        End If

        If FRM_PIZZA.CHKCHEESE.Checked = True Then
            LBLTOPPINGS.Text = "Cheese"
        End If
        If FRM_PIZZA.CHKGPEPPERS.Checked = True Then
            LBLTOPPINGS1.Text = "Green Peppers"
        End If
        If FRM_PIZZA.CHKHAM.Checked = True Then
            LBLTOPPINGS2.Text = "Ham"
        End If
        If FRM_PIZZA.CHKPEPPERONI.Checked = True Then
            LBLTOPPINGS3.Text = "Pepperoni"
        End If

        Me.LBLORDER.Text = FRM_PIZZA.TXTYORDER.Text
        Me.LBLDCHARGE.Text = "P49.00"
        Me.LBLTOTALORDER.Text = FRM_PIZZA.TXTTOTALORDER.Text


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl8.Click

    End Sub

    Private Sub lbl7_Click(sender As Object, e As EventArgs) Handles lbl7.Click

    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub LBLDCHARGE_Click(sender As Object, e As EventArgs) Handles LBLDCHARGE.Click

    End Sub


 
End Class