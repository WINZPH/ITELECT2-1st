Public Class Form1
    'Prelim_Grade'
    Dim P_Q1, P_Q2, P_Q3, P_Att, P_Act1, P_Act2, P_Act3, P_Rec1, P_Rec2, P_Exam As Double
    Dim P_TQ, PA, P_TA, P_TR, PE As Double
    'Midterm_Grade'
    Dim M_Q1, M_Q2, M_Q3, M_Att, M_Act1, M_Act2, M_Act3, M_Rec1, M_Rec2, M_Exam As Double
    Dim M_TQ, MA, M_TA, M_TR, M_E As Double
    'Final_Grade'
    Dim F_Q1, F_Q2, F_Q3, F_Att, F_Act1, F_Act2, F_Act3, F_Rec1, F_Rec2, F_Exam As Double
    Dim F_TQ, FA, F_TA, F_TR, FE As Double
    'Total_Grade'
    Dim Prelim_Grade, Midterm_Grade, Final_Grade As Double
    Private Sub CFT_TextChanged(sender As Object, e As EventArgs) Handles CFT.TextChanged

    End Sub
    'PRELIM'
    Private Sub T11_TextChanged(sender As Object, e As EventArgs) Handles T11.TextChanged
        P_Q1 = Val(T11.Text)

    End Sub

    Private Sub T12_TextChanged(sender As Object, e As EventArgs) Handles T12.TextChanged
        P_Q2 = Val(T12.Text)
    End Sub

    Private Sub T13_TextChanged(sender As Object, e As EventArgs) Handles T13.TextChanged
        P_Q3 = Val(T13.Text)
    End Sub

    Private Sub T14_TextChanged(sender As Object, e As EventArgs) Handles T14.TextChanged
        P_Att = Val(T14.Text)
    End Sub

    Private Sub T15_TextChanged(sender As Object, e As EventArgs) Handles T15.TextChanged
        P_Rec1 = Val(T15.Text)
    End Sub

    Private Sub T16_TextChanged(sender As Object, e As EventArgs) Handles T16.TextChanged
        P_Rec2 = Val(T16.Text)
    End Sub

    Private Sub T17_TextChanged(sender As Object, e As EventArgs) Handles T17.TextChanged
        P_Act1 = Val(T17.Text)
    End Sub

    Private Sub T18_TextChanged(sender As Object, e As EventArgs) Handles T18.TextChanged
        P_Act2 = Val(T18.Text)
    End Sub

    Private Sub T19_TextChanged(sender As Object, e As EventArgs) Handles T19.TextChanged
        P_Act3 = Val(T19.Text)
    End Sub

    Private Sub T110_TextChanged(sender As Object, e As EventArgs) Handles T110.TextChanged
        P_Exam = Val(T110.Text)
    End Sub

    Private Sub T21_TextChanged(sender As Object, e As EventArgs) Handles T21.TextChanged
        M_Q1 = Val(T21.Text)
    End Sub

    Private Sub T22_TextChanged(sender As Object, e As EventArgs) Handles T22.TextChanged
        M_Q2 = Val(T22.Text)
    End Sub

    Private Sub T23_TextChanged(sender As Object, e As EventArgs) Handles T23.TextChanged
        M_Q3 = Val(T23.Text)
    End Sub

    Private Sub T24_TextChanged(sender As Object, e As EventArgs) Handles T24.TextChanged
        M_Att = Val(T24.Text)
    End Sub

    Private Sub T25_TextChanged(sender As Object, e As EventArgs) Handles T25.TextChanged
        M_Rec1 = Val(T25.Text)
    End Sub

    Private Sub T26_TextChanged(sender As Object, e As EventArgs) Handles T26.TextChanged
        M_Rec2 = Val(T26.Text)
    End Sub

    Private Sub T27_TextChanged(sender As Object, e As EventArgs) Handles T27.TextChanged
        M_Act1 = Val(T27.Text)
    End Sub

    Private Sub T28_TextChanged(sender As Object, e As EventArgs) Handles T28.TextChanged
        M_Act2 = Val(T28.Text)
    End Sub

    Private Sub T29_TextChanged(sender As Object, e As EventArgs) Handles T29.TextChanged
        M_Act3 = Val(T29.Text)
    End Sub

    Private Sub T210_TextChanged(sender As Object, e As EventArgs) Handles T210.TextChanged
        M_Exam = Val(T210.Text)
    End Sub

    Private Sub ButtonTG_Click(sender As Object, e As EventArgs) Handles ButtonTG.Click
        Dim Total_Grade As Double = Prelim_Grade + Midterm_Grade + Final_Grade
        TextBox3.Text = Total_Grade
    End Sub

    Private Sub T31_TextChanged(sender As Object, e As EventArgs) Handles T31.TextChanged
        F_Q1 = Val(T31.Text)
    End Sub

    Private Sub T32_TextChanged(sender As Object, e As EventArgs) Handles T32.TextChanged
        F_Q2 = Val(T32.Text)
    End Sub

    Private Sub T33_TextChanged(sender As Object, e As EventArgs) Handles T33.TextChanged
        F_Q3 = Val(T33.Text)
    End Sub

    Private Sub T34_TextChanged(sender As Object, e As EventArgs) Handles T34.TextChanged
        F_Att = Val(T34.Text)
    End Sub

    Private Sub T35_TextChanged(sender As Object, e As EventArgs) Handles T35.TextChanged
        F_Rec1 = Val(T35.Text)
    End Sub

    Private Sub T36_TextChanged(sender As Object, e As EventArgs) Handles T36.TextChanged
        F_Rec2 = Val(T36.Text)
    End Sub

    Private Sub T37_TextChanged(sender As Object, e As EventArgs) Handles T37.TextChanged
        F_Act1 = Val(T37.Text)
    End Sub

    Private Sub T38_TextChanged(sender As Object, e As EventArgs) Handles T38.TextChanged
        F_Act2 = Val(T38.Text)
    End Sub

    Private Sub T39_TextChanged(sender As Object, e As EventArgs) Handles T39.TextChanged
        F_Act3 = Val(T39.Text)
    End Sub

    Private Sub T310_TextChanged(sender As Object, e As EventArgs) Handles T310.TextChanged
        F_Exam = Val(T310.Text)
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        P_TQ = ((P_Q1 + P_Q2 + P_Q3) / 3) * 0.25
        P_TR = ((P_Rec1 + P_Rec2) / 2) * 0.1
        P_TA = ((P_Act1 + P_Act2 + P_Act3) / 3) * 0.25
        PE = P_Exam * 0.3
        PA = P_Att * 0.1

        Prelim_Grade = (P_TA + P_TQ + P_TR + PE + PA) * 0.3

        CPT1.Text = Prelim_Grade
    End Sub

    Private Sub ButtonM_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        M_TQ = ((M_Q1 + M_Q2 + M_Q3) / 3) * 0.25
        M_TR = ((M_Rec1 + M_Rec2) / 2) * 0.1
        M_TA = ((M_Act1 + M_Act2 + M_Act3) / 3) * 0.25
        M_E = M_Exam * 0.3
        MA = M_Att * 0.1

        Midterm_Grade = (M_TA + M_TQ + M_TR + M_E + MA) * 0.3

        CMT1.Text = Midterm_Grade
    End Sub

    Private Sub ButtonF_Click(sender As Object, e As EventArgs) Handles ButtonF.Click
        F_TQ = ((F_Q1 + F_Q2 + F_Q3) / 3) * 0.25
        F_TR = ((F_Rec1 + F_Rec2) / 2) * 0.1
        F_TA = ((F_Act1 + F_Act2 + F_Act3) / 3) * 0.25
        FE = F_Exam * 0.3
        FA = F_Att * 0.1

        Final_Grade = (F_TA + F_TQ + F_TR + FE + FA) * 0.4

        CFT.Text = Final_Grade
    End Sub

End Class
