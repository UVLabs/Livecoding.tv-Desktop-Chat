Public Class fm_main


    'App Icon License: Attribution-ShareAlike 3.0 Unported

    'Icon from :  http://www.iconfinder.com

    'https://www.iconfinder.com/icons/531910/bubble_bubbles_chat_communication_dialogue_speech_talk_icon

    'No changes were made to icon.


    WithEvents browser As eWebbrowser
    Private Sub fm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create browser registry key so Webcontrol uses most up to date IE installed on machine.
        'This stops the script errors caused by leaving the default webcontrol unchecked...which uses IE9 default.
        CreateBrowserKey()
        Dim tab As New TabPage
        Dim brws As New eWebbrowser
        browser = brws
        brws.Dock = DockStyle.Fill
        brws.DocumentText = My.Resources.index
        tab.Text = "Home"
        tab.Controls.Add(brws)
        Me.tabcontrl_browser_wrap.TabPages.Add(tab)
        Me.tabcontrl_browser_wrap.SelectedTab = tab

    End Sub

    Private Sub tabcontrl_browser_wrap_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabcontrl_browser_wrap.SelectedIndexChanged

        browser = Me.tabcontrl_browser_wrap.SelectedTab.Controls(0)

    End Sub

    Private Sub browser_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles browser.NewWindow

        e.Cancel = True

    End Sub

    Private Sub browser_NewWindowExtended(ByVal sender As Object, ByVal e As eWebbrowser.WebBrowserNewWindowExtendedEventArgs) Handles browser.NewWindowExtended

        e.Cancel = True
        Dim url As String = e.Url
        Dim tab As New TabPage
        Dim brws As New eWebbrowser
        browser = brws
        brws.Dock = DockStyle.Fill
        tab.Text = "Livecoding.tv"
        tab.Controls.Add(brws)
        Me.tabcontrl_browser_wrap.TabPages.Add(tab)
        Me.tabcontrl_browser_wrap.SelectedTab = tab
        Me.tabcontrl_browser_wrap.TabPages.RemoveAt(0) 'delete first tab
        brws.Navigate2(url)

    End Sub

    Private Sub fm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        RemoveBrowerKey() 'remove browser registry key

    End Sub
End Class
