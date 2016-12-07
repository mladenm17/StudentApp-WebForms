<%@ Page Title="Student Aplication" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentWebApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">                 
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Table ID="StudentTable" runat="server" Height="287px" Width="516px">
        <asp:TableRow>
            <asp:TableCell VerticalAlign="Top">
                <asp:GridView ID="GridView_StudentList" runat="server" AutoGenerateColumns="false" OnPageIndexChanging="GridView_StudentList_PageIndexChanging" OnRowCommand="GridView_StudentList_RowCommand" AllowPaging="true">
                    <Columns>
                        <asp:TemplateField HeaderText="Select" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" ItemStyle-CssClass="test" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="GridView_StudentList_lblStudentID" runat="server" Text='<% #Eval("StudentID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="chek" runat="server" AutoPostBack ="false" Checked="false" Visible="true" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Student Name" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_StudentList_lblStudentName" runat="server" Text='<% #Eval("StudentName") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Student Surname" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_StudentList_lblStudentSurname" runat="server" Text='<% #Eval("StudentSurname") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Index Number" ItemStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle">
                            <ItemTemplate>
                                <asp:Label ID="GridView_StudentList_lblIndexNumber" runat="server" Text='<% #Eval("IndexNumber") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                         <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkBtnClk" runat="server" CommandName="SingleClick" Text="click" style="display:none;" Visible="true" CssClass="linkbtn" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="btnAdd" Text="Add" runat="server" OnClick="AddOnClick" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnEdit" Text="Edit" runat="server" OnClick="EditOnClick" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnDelete" Text="Delete" runat="server" OnClick="DeleteOnClick" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnSubject" Text="Subject" runat="server" OnClick="AddSubjectDefault" Height="25" Width="75" Visible="true" />
                <asp:Button ID="btnResults" Text="Result" runat="server" OnClick="AddResultDefault" Height="25" Width="75" Visible="true" />                                              
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>


