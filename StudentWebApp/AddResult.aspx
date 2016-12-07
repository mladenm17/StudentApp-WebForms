<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResult.aspx.cs" Inherits="StudentWebApp.AddResult" %>

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
                <asp:TextBox ID="txtResultID" Text ="0" ReadOnly="true" Width="49px" Visible="false" runat="server" DataValueField="ResultID" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblStudentName" Text="Student Name" />
                </asp:TableCell><asp:TableCell>
                <asp:DropDownList ID="dropStudentName" runat="server" Width="150" Visible="true" DataTextField="StudentName" DataValueField="StudentID" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblSubjectName" Text="Subject Name" />
                </asp:TableCell><asp:TableCell>
                <asp:DropDownList ID="dropSubjectName" runat="server" Width="150" Visible="true" DataTextField="SubjectName" DataValueField="SubjectID" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblGrade" Text="Grade" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtGrade" runat="server" Width="150" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblDate" Text="Date" />
                </asp:TableCell><asp:TableCell HorizontalAlign="Left" VerticalAlign="Top">
                <asp:TextBox ID="txtDate" ReadOnly="true" runat="server" Width="150" /><asp:ImageButton ID="ImageButton2" OnClick="ImageButton2_Click" ImageUrl="~/Images/bullet.png" Visible="true" runat="server" Width="25" />
                   <br />
                    <asp:Calendar ID="calendar2" OnSelectionChanged="calendar2_SelectionChanged" Width="100" Height="100"  runat="server" style="margin-top: 0px"></asp:Calendar>
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
