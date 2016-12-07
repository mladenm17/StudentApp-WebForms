<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResultDefault.aspx.cs" Inherits="StudentWebApp.AddResultDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" Width="530" Height="200" HorizontalAlign="center" ID="ResultTable">
        <asp:TableRow>
            <asp:TableCell VerticalAlign="top" HorizontalAlign="Center">
                <asp:GridView ID="GridView_ResultList" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="GridView_ResultList_PageIndexChanging" OnRowCommand="GridView_ResultList_RowCommand" AllowPaging="true">
                    <Columns>
                        <asp:TemplateField HeaderText="ResultID" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" ItemStyle-CssClass="test" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="GridView_ResultList_lblResultID" runat="server" Text='<% #Eval("ResultID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="check" runat="server" AutoPostBack="false"  Visible="true" Checked="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="StudentName" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_ResultList_lblStudentName" runat="server" Text='<% #Eval("StudentName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SubjectName" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_ResultList_lblSubjectName" runat="server" Text='<% #Eval("SubjectName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Grade" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_ResultList_lblGrade" runat="server" Text='<% #Eval("Grade") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField HeaderText="Date" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_ResultList_lblDate" runat="server" Text='<% #Eval("Date") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Center">
                <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="AddOnClick" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnEdit" Text="Edit" runat="server" OnClick="EditOnClick" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="DeleteOnClick" Height="25" Width="75" Visible="true" />
               
            </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
