<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="APF_Calculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="calculadora_main" runat="server">
        <div>
            <h1><b>Calculadora</b></h1>
            <table border="1" width="20%">
                <tr>
                    <th colspan="4">
                        <asp:Label ID="tbOperation"
                        Text=""
                        runat="server"
                        Height="10px"
                            />
                    </th>
                </tr>
                <tr>
                    <th colspan="4">
                        <asp:Label ID="tbNumbers"
                        Text=""
                        runat="server" 
                        Height="10px"
                            />
                    </th>
                </tr>
                <tr>
                    <th>
                        <asp:Button ID="btn7"
                            Text="7"
                            OnClick="btnNumClick"
                            runat="server" Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn8"
                            Text="8"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn9"
                            Text="9"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btnDiv"
                            Text="/"
                            OnClick="btnOperation"
                            runat="server"
                            Width="100%"/>
                    </th>
                </tr>
                <tr>
                    <th>
                        <asp:Button ID="btn4"
                            Text="4"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn5"
                            Text="5"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn6"
                            Text="6"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btnMult"
                            Text="X"
                            OnClick="btnOperation"
                            runat="server"
                            Width="100%"/>
                    </th>
                </tr>
                <tr>
                    <th>
                        <asp:Button ID="btn1"
                            Text="1"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn2"
                            Text="2"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btn3"
                            Text="3"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btnSubs"
                            Text="-"
                            OnClick="btnOperation"
                            runat="server"
                            Width="100%"/>
                    </th>
                </tr>
                <tr>
                    <th>
                        <%--<asp:Button ID="btnEmpty1"
                            Text=""
                            OnClick=""
                            runat="server" 
                            Width="100%"/>--%>
                    </th>
                    <th>
                        <asp:Button ID="btn0"
                            Text="0"
                            OnClick="btnNumClick"
                            runat="server" 
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btnResult"
                            Text="="
                            OnClick="btnResultOperation"
                            runat="server"
                            Width="100%"/>
                    </th>
                    <th>
                        <asp:Button ID="btnAdd"
                            Text="+"
                            OnClick="btnOperation"
                            runat="server" 
                            Width="100%"/>
                    </th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
