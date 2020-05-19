<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Call Through ServiceWeb</h2>
            <p>
                <asp:Button ID="CallWeb" runat="server" OnClick="CallWeb_Click" Text="Web" />
                <asp:Button ID="CallWebA" runat="server" OnClick="CallWebA_Click" Text="Web-&gt;A" />
                <asp:Button ID="CallWebAB" runat="server" OnClick="CallWebAB_Click" Text="Web-&gt;A-&gt;B" />
                <asp:Button ID="CallWebB" runat="server" OnClick="CallWebB_Click" Text="Web -&gt; B" />
                <asp:Button ID="CallWebBA" runat="server" OnClick="CallWebBA_Click" Text="Web -&gt; B -&gt; A" />
            </p>
            <p>
                <asp:Literal ID="LiteralWeb" runat="server"></asp:Literal>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Call ServiceA</h2>
            <p>
                <asp:Button ID="CallA" runat="server" OnClick="CallA_Click" Text="A" />
                <asp:Button ID="CallAB" runat="server" OnClick="CallAB_Click" Text="A -&gt; B" />
            </p>
            <p>
                <asp:Literal ID="LiteralA" runat="server"></asp:Literal>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Call ServiceB</h2>
            <p>
                <asp:Button ID="CallB" runat="server" OnClick="CallB_Click" Text="B" />
                <asp:Button ID="CallBA" runat="server" OnClick="CallBA_Click" Text="B -&gt; A" />
            </p>
            <p>
                <asp:Literal ID="LiteralB" runat="server"></asp:Literal>
            </p>
        </div>
    </div>

</asp:Content>
