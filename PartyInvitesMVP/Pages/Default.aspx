<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PartyInvitesMVP.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Content/PartyStyles.css" />
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <h1>New Year's Eve at Jacqui`s!</h1>
            <p>We're going to have an exciting party. And you're invited!</p>
        </div>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true"/>

        <div><label for="id">Your name:</label><input type="text" id="name" runat="server" /></div>
        <div><label for="email">Your email:</label><input type="text" id="email" runat="server" /></div>
        <div><label for="phone">Your phone:</label><input type="text" id="phone" runat="server" /></div>
        <div>
            <label for="willattend">Will you attend?</label>
            <select id="willattend" runat="server">
                <option value="">Choose an option</option>
                <option value="true">Yes</option>
                <option value="false">No</option>
            </select>
        </div>
        <div>
            <button type="submit">Submit RSVP</button>
        </div>
    </form>
</body>
</html>
