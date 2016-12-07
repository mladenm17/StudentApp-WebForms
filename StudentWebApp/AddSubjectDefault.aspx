<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSubjectDefault.aspx.cs" Inherits="StudentWebApp.AddSubjectDefault" %>

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
                <asp:GridView ID="GridView_SubjectList" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="GridView_SubjectList_PageIndexChanging" OnRowCommand="GridView_SubjectList_RowCommand" AllowPaging="true">
                    <Columns>
                        <asp:TemplateField HeaderText="SubjectID" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" ItemStyle-CssClass="test" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="GridView_SubjectList_lblSubjectID" runat="server" Text='<% #Eval("SubjectID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="check" runat="server" AutoPostBack="false"  Visible="true" Checked="false" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="SubjectName" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_SubjectList_lblSubjectName" runat="server" Text='<% #Eval("SubjectName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Professor" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_SubjectListList_lblProfessor" runat="server" Text='<% #Eval("Professor") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Semestre" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_SubjectListList_lblSemestre" runat="server" Text='<% #Eval("Semestre") %>' />
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

    </div>
    </form>
</body>
</html>
