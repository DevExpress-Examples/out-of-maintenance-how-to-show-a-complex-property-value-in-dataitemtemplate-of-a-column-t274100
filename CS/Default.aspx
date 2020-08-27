<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <dx:aspxcardview ID="ASPxCardView1" AutoGenerateColumns="False"  EnableCardsCache="False" runat="server" DataSourceID="ObjectDataSource1" KeyFieldName="Id">
            <SettingsBehavior AllowFocusedCard="True" />
            <Columns>
                <dx:CardViewTextColumn FieldName="Id" VisibleIndex="0" Width="10%">
                </dx:CardViewTextColumn>
                <dx:CardViewTextColumn FieldName="Name" VisibleIndex="1" Width="30%">
                </dx:CardViewTextColumn>
                <dx:CardViewTextColumn Caption="Street" FieldName="Address" VisibleIndex="2" Width="30%">
                    <DataItemTemplate>
                        <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Text='<%# Eval("Address.Street") %>' Width="100%"></dx:ASPxTextBox>
                    </DataItemTemplate>
                </dx:CardViewTextColumn>
                <dx:CardViewTextColumn Caption="City" FieldName="Address" VisibleIndex="3" Width="33%">
                    <DataItemTemplate>
                        <dx:ASPxTextBox ID="ASPxTextBox2" runat="server" Text='<%# Eval("Address.City") %>' Width="100%"></dx:ASPxTextBox>
                    </DataItemTemplate>
                </dx:CardViewTextColumn>
            </Columns>
        </dx:aspxcardview>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectData" TypeName="Person">
        </asp:ObjectDataSource>    
    </div>
    </form>
</body>
</html>
