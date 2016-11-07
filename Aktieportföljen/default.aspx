<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Aktieportföljen._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset= "utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1" />
    <script type="text/javascript" src="js/menu.js"></script>
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/rs.css" rel="stylesheet" />
    <title>JE-Bankens aktier</title>
</head>
<body>
	<div class="top-black"></div>
	<div class="top-white"></div>
	<div class="container">
		<div class="page-title">
			<h2>JE-Bankens aktier</h2>
		</div>
		<div class="nav">
            <div class="home"><a href="default.aspx">Hem</a></div>
			<ul class="topnav" id="myTopnav">
                <li class="icon"><a href="javascript:void(0);" onclick="myFunction()">&#9776;</a></li>
                <li> 
                    <form id="DropDownForm" class="ddlst" runat="server">
                        <asp:DropDownList ID="DropDownLst" class="listsyle" runat="server">
                        <asp:ListItem value="AB" Selected="True">A + B aktier</asp:ListItem>
                        <asp:ListItem value="A">A aktier</asp:ListItem>
                        <asp:ListItem value="B">B aktier</asp:ListItem>
                        </asp:DropDownList>
                    </form>
                </li>
                <li><a href="default.aspx?cap=small">Small Cap</a></li>
                <li><a href="default.aspx?cap=mid">Mid Cap</a></li>
                <li><a href="default.aspx?cap=large">Large Cap</a></li>                                                         			
			</ul>
            
		</div>  
		<div class="article">
			<div class="textfield">
				<h3>Aktielistan</h3>
                <p></p>
                <table>
                    <thead>
                        <tr>
                            <th>Namn</th>
                            <th>Köp</th>
                            <th>Sälj</th>
                            <th>Cap</th>
                            <th>Typ</th>
                        </tr>
                    </thead>
                    <tbody id="stocktable" runat="server">

                    </tbody>
                </table>
			</div>
		</div>
        <div class="footer">
		    <h3>JE-Bankens aktieportal</h3>
		    <p>Ansvarig för sidan: Morgan Norell</p>
	    </div>	
	<div class="bottom-black"></div>
    </div>
</body>
</html>
