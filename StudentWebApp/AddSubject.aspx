<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="StudentWebApp.AddSubject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" Width="1200" HorizontalAlign="center">
        <asp:TableRow>
            <asp:TableCell Width="162px">
                <asp:TextBox ID="txtSubjectID" Text ="0" ReadOnly="true" Width="49px" Visible="false" runat="server" DataValueField="SubjectID" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblSubjectName" Text="Subject Name" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtSubjectName" runat="server" Width="150" />
                    </asp:TableCell> 
            </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblProfessor" Text="Professor" />
                </asp:TableCell><asp:TableCell>
               <asp:TextBox ID="txtProfessor" runat="server" Width="150" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblSemestre" Text="Semestre" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtSemestre" runat="server" Width="150" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Button ID="btnAddStudent" runat="server" OnClick="btnAddStudent_Click" Text="Add Student"/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Button ID="btnAddSubject" runat="server" OnClick="btnAddSubject_Click" Text="Add Subject"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <asp:Button ID="btnSave" runat="server" OnClick ="btnSave_Click" Text="Save" />
    </div>
    </form>
</body>
</html>

