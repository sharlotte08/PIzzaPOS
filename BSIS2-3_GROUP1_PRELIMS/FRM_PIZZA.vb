Public Class FRM_PIZZA

    Private Sub TXTCONTACT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCONTACT.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid: This field will only accept number.")
        End If
    End Sub

    Public Sub hawaiian()
        Dim order, totalorder As Double
        Const base8 = 279
        Const base10 = 379
        Const base12 = 419
        Const base15 = 579

        Const extracheese = 20
        Const extrapeppers = 18
        Const extraham = 25
        Const extrapepperoni = 30

        If RBT8.Checked = True And CHKCHEESE.Checked = True Then
            order = base8 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKHAM.Checked = True Then
            order = base8 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True Then
            order = base8
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT10.Checked = True And CHKCHEESE.Checked = True Then
            order = base10 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base10 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKHAM.Checked = True Then
            order = base10 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base10 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True Then
            order = base10
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT12.Checked = True And CHKCHEESE.Checked = True Then
            order = base12 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base12 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKHAM.Checked = True Then
            order = base12 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base12 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base12
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT15.Checked = True And CHKCHEESE.Checked = True Then
            order = base15 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base15 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKHAM.Checked = True Then
            order = base15 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base15 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base15
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

    End Sub

    Public Sub cheeseclassic()
        Dim order, totalorder As Double
        Const base8 = 249
        Const base10 = 349
        Const base12 = 409
        Const base15 = 549

        Const extracheese = 20
        Const extrapeppers = 18
        Const extraham = 25
        Const extrapepperoni = 30

        If RBT8.Checked = True And CHKCHEESE.Checked = True Then
            order = base8 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKHAM.Checked = True Then
            order = base8 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True Then
            order = base8
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT10.Checked = True And CHKCHEESE.Checked = True Then
            order = base10 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base10 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKHAM.Checked = True Then
            order = base10 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base10 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True Then
            order = base10
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT12.Checked = True And CHKCHEESE.Checked = True Then
            order = base12 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base12 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKHAM.Checked = True Then
            order = base12 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base12 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base12
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT15.Checked = True And CHKCHEESE.Checked = True Then
            order = base15 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base15 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKHAM.Checked = True Then
            order = base15 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base15 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base15
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If
    End Sub

    Public Sub pepperoniclassic()
        Dim order, totalorder As Double
        Const base8 = 279
        Const base10 = 379
        Const base12 = 419
        Const base15 = 579

        Const extracheese = 20
        Const extrapeppers = 18
        Const extraham = 25
        Const extrapepperoni = 30

        If RBT8.Checked = True And CHKCHEESE.Checked = True Then
            order = base8 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKHAM.Checked = True Then
            order = base8 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True Then
            order = base8
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT10.Checked = True And CHKCHEESE.Checked = True Then
            order = base10 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base10 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKHAM.Checked = True Then
            order = base10 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base10 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True Then
            order = base10
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT12.Checked = True And CHKCHEESE.Checked = True Then
            order = base12 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base12 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKHAM.Checked = True Then
            order = base12 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base12 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base12
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT15.Checked = True And CHKCHEESE.Checked = True Then
            order = base15 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base15 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKHAM.Checked = True Then
            order = base15 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base15 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base15
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If
    End Sub

    Public Sub hamcheeseclassic()
        Dim order, totalorder As Double
        Const base8 = 279
        Const base10 = 379
        Const base12 = 419
        Const base15 = 579

        Const extracheese = 20
        Const extrapeppers = 18
        Const extraham = 25
        Const extrapepperoni = 30

        If RBT8.Checked = True And CHKCHEESE.Checked = True Then
            order = base8 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKHAM.Checked = True Then
            order = base8 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True Then
            order = base8
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT10.Checked = True And CHKCHEESE.Checked = True Then
            order = base10 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base10 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKHAM.Checked = True Then
            order = base10 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base10 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True Then
            order = base10
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT12.Checked = True And CHKCHEESE.Checked = True Then
            order = base12 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base12 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKHAM.Checked = True Then
            order = base12 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base12 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base12
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT15.Checked = True And CHKCHEESE.Checked = True Then
            order = base15 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base15 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKHAM.Checked = True Then
            order = base15 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base15 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base15
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

    End Sub

    Public Sub hampineapple()
        Dim order, totalorder As Double
        Const base8 = 279
        Const base10 = 379
        Const base12 = 419
        Const base15 = 579

        Const extracheese = 20
        Const extrapeppers = 18
        Const extraham = 25
        Const extrapepperoni = 30

        If RBT8.Checked = True And CHKCHEESE.Checked = True Then
            order = base8 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKHAM.Checked = True Then
            order = base8 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base8 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT8.Checked = True Then
            order = base8
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT10.Checked = True And CHKCHEESE.Checked = True Then
            order = base10 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base10 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKHAM.Checked = True Then
            order = base10 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base10 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT10.Checked = True Then
            order = base10
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT12.Checked = True And CHKCHEESE.Checked = True Then
            order = base12 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base12 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKHAM.Checked = True Then
            order = base12 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base12 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base12
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

        If RBT15.Checked = True And CHKCHEESE.Checked = True Then
            order = base15 + extracheese
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKGPEPPERS.Checked = True Then
            order = base15 + extrapeppers
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKHAM.Checked = True Then
            order = base15 + extraham
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT15.Checked = True And CHKPEPPERONI.Checked = True Then
            order = base15 + extrapepperoni
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        ElseIf RBT12.Checked = True Then
            order = base15
            totalorder = order + 49
            TXTYORDER.Text = Format(order, "#,###,##0.00")
            TXTTOTALORDER.Text = Format(totalorder, "#,###,##0.00")
        End If

    End Sub

    Private Sub BTNPROCESS_Click(sender As Object, e As EventArgs) Handles BTNPROCESS.Click
        TXTDCHARGE.Text = "49.00"
        If RBTHAWAIIAN.Checked = True Then
            hawaiian()
        ElseIf RBTCCLASS.Checked = True Then
            cheeseclassic()
        ElseIf RBTPCLASS.Checked = True Then
            pepperoniclassic()
        ElseIf RBTHCCLASS.Checked = True Then
            hamcheeseclassic()
        ElseIf RBTHPINEAPP.Checked = True Then
            hampineapple()
        End If
    End Sub

    Private Sub BTNPRINT_Click(sender As Object, e As EventArgs) Handles BTNPRINT.Click
        FRM_RECEIPT.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTNOTE.TextChanged

    End Sub

    Private Sub TXTCNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTCNAME.TextChanged

    End Sub

    Private Sub TXTCADD_TextChanged(sender As Object, e As EventArgs) Handles TXTCADD.TextChanged

    End Sub

    Private Sub TXTCONTACT_TextChanged(sender As Object, e As EventArgs) Handles TXTCONTACT.TextChanged

    End Sub

  
End Class