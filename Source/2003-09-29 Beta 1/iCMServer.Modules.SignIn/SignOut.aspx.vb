Imports System.Web.Security

Public Class SignOut
    Inherits System.Web.UI.Page

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

        ' Log User Off from Cookie Authentication System
        FormsAuthentication.SignOut()

        ' Invalidate roles token
        Response.Cookies("siteroles").Value = Nothing
        Response.Cookies("siteroles").Path = "/"
        Response.Cookies("siteroles").Expires = New System.DateTime(1999, 10, 12)

        ' Redirect user back to the Portal Home Page'
        Response.Redirect("~/icm.aspx")

    End Sub

End Class
