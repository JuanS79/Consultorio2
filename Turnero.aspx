<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Turnero.aspx.cs" Inherits="Consultorio2.Turnero" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .form-style-10 input[type="button"], 
        .form-style-10 input[type="submit"]{
	        background: #2A88AD;
	        padding: 8px 20px 8px 20px;
	        border-radius: 5px;
	        -webkit-border-radius: 5px;
	        -moz-border-radius: 5px;
	        color: #fff;
	        text-shadow: 1px 1px 3px rgba(0, 0, 0, 0.12);
	        -moz-box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.17);
	        -webkit-box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.17);
	        box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.17);
	        border: 1px solid #257C9E;
	        font-size: 15px;
                    font-style: normal;
                    font-variant: normal;
                    font-weight: normal;
                    line-height: normal;
                    font-family: Bitter, serif;
                    margin-left: 18px;
                }
        .form-style-10 input[type="button"]:hover, 
        .form-style-10 input[type="submit"]:hover{
	        background: #2A6881;
	        -moz-box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.28);
	        -webkit-box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.28);
	        box-shadow: inset 0px 2px 2px 0px rgba(255, 255, 255, 0.28);
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            Que onda perros, que órgano anda fallando?<br />
        </div>
        
        <p>
            <asp:Button ID="Clinica" runat="server" Text="Clinica" Width="57px"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cirugia" runat="server" Text="Cirugia" />
            <br>
            <asp:Button ID="Pediatria" runat="server" Text="Pediatria" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cardiologia" runat="server" Text="Cardiologia" />
        </p>
        
        <p>
            &nbsp;</p>
        <asp:Button ID="cancelar" runat="server" Text="Cancelar" OnClick="cancelar_Click" />

         <div class="section"><span>3</span>Clave</div>
        <div class="inner-wrap">
			<label >Clave<asp:TextBox ID="registro_clave" runat="server"></asp:TextBox></label>
			<label >Confirma tu Clave<asp:TextBox ID="registro_confirma" runat="server"></asp:TextBox></label>
        <div>
			<asp:Button ID="Button1" runat="server" Text="Registrate" Width="176px" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" Width="155px" />
		</div>		
		</div>
    </form>
    </body>
</html>
