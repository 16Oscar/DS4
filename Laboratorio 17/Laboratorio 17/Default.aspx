<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

      <div class="row">
          <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
              AllowSorting="true" AllowPaging="true"
              DataKeyNames="ProductID"
              AutoGenerateEditButton="True"
              runat="server" />

          <asp:SqlDataSource ID="MyDataSource1" runat="server"
              ConnectionString="data Source=16OSCAR\SQLEXPRESS;initial catalog=Northwind;persist security info=True;Integrated Security=SSPI;"
              ProviderName="System.Data.SqlClient"
              SelectCommand="Select ProductID, ProductName, UnitPrice From Products"
              UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductId]=@ProductId">

          </asp:SqlDataSource>
           
      </div>
    

</asp:Content>
