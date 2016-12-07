<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="StudentWebApp.AddStudent" %>

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
            <asp:TableCell Width="12px">
                <asp:TextBox ID="txtID" Text ="0" ReadOnly="true" Width="49px" Visible="false" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblStudentName" Text="Name" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtStudentName" runat="server" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblSurname" Text="Surname" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtStudentSurname" runat="server" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblIndexNumber" Text="Index Number" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtIndexNumber" runat="server" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblAdress" Text="Adress" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtAdress" runat="server" />
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblBirthDate" Text="Birth Date" />
                </asp:TableCell><asp:TableCell HorizontalAlign="Left" VerticalAlign="Top">
                <asp:TextBox ID="txtBirthDate" ReadOnly="true" runat="server" /><asp:ImageButton ID="ImageButton1" OnClick="ImageButton1_Click" ImageUrl="~/Images/bullet.png" Visible="true" runat="server" Width="25" />
                   <br />
                    <asp:Calendar ID="calendar1" OnSelectionChanged="calendar1_SelectionChanged" Width="100" Height="100"  runat="server" style="margin-top: 0px"></asp:Calendar>
                    </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell  HorizontalAlign="Left" VerticalAlign="Top">
                <asp:Label runat="server" ID="lblSex" Text="Sex" />
                </asp:TableCell><asp:TableCell>
                <asp:TextBox ID="txtSex" runat="server" />
                    </asp:TableCell>        
        </asp:TableRow>
    </asp:Table>
        <asp:Button ID="btnSave" runat="server" OnClick="btnSaveClick" Text="Save" />
    </div>
    </form>
</body>
</html>
