Public Class HpMpUserControl

    Delegate Sub revcoverRolePetValue(ByVal ratio)


    Private Sub CheckBoxEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEnable.CheckedChanged
        TimerRecover.Enabled = CheckBoxEnable.Checked
    End Sub


    Private Sub TrackBarRatio_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarRatio.Scroll

    End Sub

End Class
