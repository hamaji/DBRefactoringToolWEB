<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="~/Content/style.css"/>
    <title>DBリファクタリング</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br>
            <asp:Button ID="Button1" runat="server" Text="クリックしてください" OnClick="Button1_Click" />
            <asp:GridView ID="columnlist1" runat="server"></asp:GridView>
        </div>
        <div class="svg_area" id="svg_area"></div>
        <!--<script type="text/javascript" src="libs/d3.js" charset="utf-8"></script>-->
        <script type="text/javascript" src="http://d3js.org/d3.v3.min.js" charset="utf-8"></script>
        <!-- scripts -->
        <script type="text/javascript" src="http://localhost:55129/Scripts/main.js" charset="utf-8"></script>
    </form>
</body>
</html>
