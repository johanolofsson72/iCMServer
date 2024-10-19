Public Class PagesEngine
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

#Region " XmlHttpRequest Functions "

    Public Function CreateXMLBasedOnXmlHttpRequest(ByVal sID As String) As String
        '-------------------------------------------------------------------------
        'Description:   CreateXMLBasedOnXmlHttpRequest
        'Parameters:    sID
        'Returns:       XML String
        'Comments:      -
        'Revision:      Johan Olofsson, 2002-09-12, Created
        '-------------------------------------------------------------------------

        ' Standard variables
        Dim aIDHolder() As String
        Dim sXML As String

        ' Do Shit
        aIDHolder = Split(sID, ",")

        Select Case CLng(aIDHolder(0))
            Case 0
                sXML = GetRootNodes(CLng(aIDHolder(0)), CLng(aIDHolder(1)), CLng(aIDHolder(2)))

            Case Else
                sXML = GetChildNodes(CLng(aIDHolder(0)), CLng(aIDHolder(1)), CLng(aIDHolder(2)))

        End Select

        ' Well, everything seems to be OK, let's say it did
        Return sXML

    End Function

    Private Function GetRootNodes(ByVal iID As Integer, ByVal iIndent As Integer, ByVal iRollup As Integer) As String
        '-------------------------------------------------------------------------
        'Description:   GetRootNodes
        'Parameters:    iID
        '               iIndent
        '               iRollup
        'Returns:       String
        'Comments:      -
        'Revision:      Johan Olofsson, 2002-09-12, Created
        '               Johan Olofsson, 2003-08-09, Edited
        '-------------------------------------------------------------------------

        ' Standard variables
        Dim oPag As New clsPages
        Dim sXML As String

        ' Do Shit
        sXML = oPag.GetNodesAsXML(iIndent, 0)

        ' Well, everything seems to be OK, let's say it did
        Return sXML

    End Function

    Private Function GetChildNodes(ByVal iID As Integer, ByVal iIndent As Integer, ByVal iRollup As Integer) As String
        '-------------------------------------------------------------------------
        'Description:   GetChildNodes
        'Parameters:    iID
        '               iIndent
        '               iRollup
        'Returns:       String
        'Comments:      -
        'Revision:      Johan Olofsson, 2002-09-12, Created
        '               Johan Olofsson, 2003-08-09, Edited
        '-------------------------------------------------------------------------

        ' Standard variables
        Dim oPag As New clsPages
        Dim sXML As String

        ' Do Shit
        sXML = oPag.GetNodesAsXML(iIndent, iID)

        ' Well, everything seems to be OK, let's say it did
        Return sXML

    End Function

#End Region

End Class
