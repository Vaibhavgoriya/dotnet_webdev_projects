<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assigments._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <main class="container mt-4">

        <!-- Accept Name and Display Welcome Message -->
        <div class="mb-4">
            <h3>Welcome Message</h3>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control mb-2" placeholder="Enter your name"></asp:TextBox>
            <asp:Button ID="btnWelcome" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="BtnWelcome_Click" />
            <asp:Label ID="lblWelcomeMessage" runat="server" CssClass="d-block mt-2 text-success"></asp:Label>
        </div>

        <!-- Temperature Conversion -->
        <div class="mb-4">
            <h3>Temperature Conversion</h3>
            <asp:TextBox ID="txtTemperature" runat="server" CssClass="form-control mb-2" placeholder="Enter temperature in Celsius"></asp:TextBox>
            <asp:Button ID="btnConvert" runat="server" Text="Convert to Fahrenheit" CssClass="btn btn-secondary" OnClick="BtnConvert_Click" />
            <asp:Label ID="lblTemperatureResult" runat="server" CssClass="d-block mt-2 text-success"></asp:Label>
        </div>

        <!-- Algebraic Operations -->
        <div class="mb-4">
            <h3>Algebraic Operations</h3>
            <asp:TextBox ID="txtNumber1" runat="server" CssClass="form-control mb-2" placeholder="Enter first number"></asp:TextBox>
            <asp:TextBox ID="txtNumber2" runat="server" CssClass="form-control mb-2" placeholder="Enter second number"></asp:TextBox>
            <asp:DropDownList ID="ddlOperation" runat="server" CssClass="form-select mb-2">
                <asp:ListItem Text="Addition" Value="+" />
                <asp:ListItem Text="Subtraction" Value="-" />
                <asp:ListItem Text="Multiplication" Value="*" />
                <asp:ListItem Text="Division" Value="/" />
            </asp:DropDownList>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CssClass="btn btn-secondary" OnClick="BtnCalculate_Click" />
            <asp:Label ID="lblCalculationResult" runat="server" CssClass="d-block mt-2 text-success"></asp:Label>
        </div>

        <!-- Demonstrate AutoPostBack -->
        <div class="mb-4">
            <h3>AutoPostBack Example</h3>
            <asp:DropDownList ID="ddlColors" runat="server" CssClass="form-select mb-2" AutoPostBack="true" OnSelectedIndexChanged="DdlColors_SelectedIndexChanged">
                <asp:ListItem Text="Select a Color" Value="" />
                <asp:ListItem Text="Red" Value="Red" />
                <asp:ListItem Text="Green" Value="Green" />
                <asp:ListItem Text="Blue" Value="Blue" />
            </asp:DropDownList>
            <asp:Label ID="lblColorMessage" runat="server" CssClass="d-block mt-2 text-success"></asp:Label>
        </div>

    </main>

</asp:Content>
