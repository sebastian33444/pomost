﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dokument.aspx.cs" Inherits="Dokument" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<!-- TinyMCE -->
<script type="text/javascript" src="tinymce/jscripts/tiny_mce/tiny_mce.js"></script>
<script type="text/javascript">
    tinyMCE.init({
        // General options
        mode: "textareas",
        theme: "advanced",
        skin: "o2k7",
        plugins: "autolink,lists,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,insertdatetime,preview,media,searchreplace,print,contextmenu,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,inlinepopups,autosave",

        // Theme options
        theme_advanced_buttons1: "save,newdocument,|,bold,italic,underline,strikethrough,|,justifyleft,justifycenter,justifyright,justifyfull,|,styleselect,formatselect,fontselect,fontsizeselect",
        theme_advanced_buttons2: "cut,copy,paste,pastetext,pasteword,|,search,replace,|,bullist,numlist,|,outdent,indent,blockquote,|,undo,redo,|,link,unlink,anchor,image,cleanup,help,code,|,insertdate,inserttime,preview,|,forecolor,backcolor",
        theme_advanced_buttons3: "tablecontrols,|,hr,removeformat,visualaid,|,sub,sup,|,charmap,emotions,iespell,media,advhr,|,print,|,ltr,rtl,|,fullscreen",
        theme_advanced_buttons4: "insertlayer,moveforward,movebackward,absolute,|,styleprops,|,cite,abbr,acronym,del,ins,attribs,|,visualchars,nonbreaking,template,pagebreak,restoredraft",
        theme_advanced_toolbar_location: "top",
        theme_advanced_toolbar_align: "left",
        theme_advanced_statusbar_location: "bottom",
        theme_advanced_resizing: true,

        // Example word content CSS (should be your site CSS) this one removes paragraph margins
        content_css: "css/word.css",

        // Drop lists for link/image/media/template dialogs
        template_external_list_url: "lists/template_list.js",
        external_link_list_url: "lists/link_list.js",
        external_image_list_url: "lists/image_list.js",
        media_external_list_url: "lists/media_list.js",

        // Replace values for the template plugin
        template_replace_values: {
            username: "Some User",
            staffid: "991234"
        }
    });
</script>
<!-- /TinyMCE -->


</head>
<body>
    <form id="form1" runat="server" >
        <textarea id="elm1" name="elm1" style="width: 100%; height: 330px;" runat="server"> Jakaś zawartość   </textarea>
        <br />        
        <br />
        <asp:RadioButtonList ID="RBLista" runat="server">
            <asp:ListItem>wniosek</asp:ListItem>
            <asp:ListItem>odwołanie</asp:ListItem>
            <asp:ListItem>decyzja</asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="TextBox1" runat="server" Height="90px" style="margin-top: 0px" Width="330px"></asp:TextBox>
        <br />
        <input type="submit" name="save" value="Zapisz" />
	<input type="reset" name="reset" value="Reset" />
        <br />
        <br />
        <asp:Button ID="BZapisz_do_bazy" runat="server" OnClick="BZapisz_do_bazy_Click" Text="Zapisz do bazy" />
        <br />
     </form>
    
    </body>
</html>