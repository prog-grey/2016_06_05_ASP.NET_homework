<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Testing_WebForms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link href="Style/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
		<asp:Panel ID="tasks" runat="server">
			<asp:BulletedList ID="BulletedListTasks" runat="server" BulletStyle="Numbered"></asp:BulletedList>
			<asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
		</asp:Panel>
    </form>
</body>
</html>
