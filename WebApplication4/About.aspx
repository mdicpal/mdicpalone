<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div style="padding-top:20px">

        <asp:Repeater ID="repeatone" runat="server">
            <ItemTemplate>
            <div class="alert alert-success" role="alert">
                <h3><%#Eval("Quotes") %></h3>
                <p style="text-align: left; font-style: italic">
                    - <%#Eval("author") %>
                </p>
            </div>
        </ItemTemplate>

        <AlternatingItemTemplate>
            <div class="alert alert-danger" role="alert">

                <h3><%#Eval("Quotes") %></h3>
                <p style="text-align: left; font-style: italic">
                    - <%#Eval("author") %>
                </p>
            </div>
        </AlternatingItemTemplate>       
            </asp:Repeater>      
        
    </div>
</asp:Content>
