Imports iConsulting
Imports iConsulting.iCMServer
Imports iConsulting.iCMServer.iCDataManager
Imports System.Web
Imports System.Web.Security

Public MustInherit Class SignIn : Inherits clsSiteModuleControl

    Protected WithEvents Requiredfieldvalidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents Requiredfieldvalidator2 As System.Web.UI.WebControls.RequiredFieldValidator
    ' Obtain SiteSettings from Current Context
    Private _SiteSettings As clsSiteSettings = CType(HttpContext.Current.Items("SiteSettings"), clsSiteSettings)
    Protected WithEvents Header As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Content As System.Web.UI.HtmlControls.HtmlGenericControl
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents UserName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents UserPass As System.Web.UI.WebControls.TextBox
    Protected WithEvents LoginBtn As System.Web.UI.WebControls.Button
    Protected WithEvents RegularExpressionValidator1 As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents Msg As System.Web.UI.WebControls.Label
    Protected WithEvents lblHeader As System.Web.UI.WebControls.Label
    Protected WithEvents lblText1 As System.Web.UI.WebControls.Label
    Protected WithEvents lblText2 As System.Web.UI.WebControls.Label
    ' Set LanguageText
    Dim oLanguageText As New clsLanguageText

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim al As New System.Collections.ArrayList
        al = oLanguageText.GetLanguageTextByLocation(_SiteSettings.Language, "iConsulting.iCMServer")
        Label1.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_username"))
        Label2.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_password"))
        LoginBtn.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_signin"))
        lblHeader.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_signin"))
        lblText1.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_cookietext1")) '"Om du loggar in kommer cookies att användas."
        lblText2.Text = Server.HtmlDecode(oLanguageText.Find(al, "sys_cookietext2")) '"Kan endast undvikas genom att inte logga in."
        RegularExpressionValidator1.ErrorMessage = Server.HtmlDecode(oLanguageText.Find(al, "sys_errormessage")) '"eroor"
    End Sub

    Public Sub LoginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Page.IsValid Then
            Dim oSignIn As New clsSignIn
            Dim sUserEmail As String = oSignIn.Login(UserName.Text, UserPass.Text)
            If Not (sUserEmail Is Nothing) And sUserEmail <> "" Then
                Try
                    ' Log User Off from Cookie Authentication System
                    FormsAuthentication.SignOut()
                    ' Invalidate roles token
                    Response.Cookies("siteroles").Value = Nothing
                    Response.Cookies("siteroles").Path = "/"
                    Response.Cookies("siteroles").Expires = New System.DateTime(1999, 10, 12)
                Catch ex As Exception

                Finally
                    ' Use security system to set the UserID within a client-side Cookie
                    FormsAuthentication.SetAuthCookie(UserName.Text, False)
                    ' Redirect browser back to originating page
                    Response.Redirect(Request.ApplicationPath)
                End Try
            Else
                Msg.Text = "<" & "br" & ">" & Server.HtmlDecode(oLanguageText.Find(_SiteSettings.LanguageText, "sys_loginfailed")) & "<" & "br" & ">"
            End If
        End If
    End Sub
End Class

