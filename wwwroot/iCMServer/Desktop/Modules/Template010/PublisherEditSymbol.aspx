<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PublisherEditSymbol.aspx.vb" Inherits="iConsulting.iCMServer.Modules.Template010.PublisherEditSymbol"%>
<%@ Register TagPrefix="iCMServerStyle" TagName="Title" Src="~/Server/Css/iCMServerStyle.ascx"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>Symbol</title>
		<icmserverstyle:title id="iCMServerStyle1" ViewSource="Main" ViewType="Standard" runat="server"></icmserverstyle:title>
		<style type="text/css"><!--.ColorItems { cursor: hand}
	--> 
	</style>
		<script>
			function ReturnSelectedSymbol(){
				try{
					window.opener.InsertNewSymbol(SymbolSelector.value);
					window.close();
				}
				catch(e){
					this.close;
				}
				
			}
		</script>
</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="5" topmargin="5" bgcolor="buttonface" style="OVERFLOW: hidden">
		<fieldset>
			<table border="0" align="center" id=Table1>
				<tr>
					<td>
						<select id='SymbolSelector' size="6" style="WIDTH: 94px; HEIGHT: 102px" onDblClick="ReturnSelectedSymbol();" name=SymbolSelector>
							<option value='�' selected>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='"'>
							"
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='#'>
							#
							<option value='&amp;'>
							&amp;
							<option value='<'>
							&lt;
							<option value='>'>
							&gt;
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							&amp;#;
							<option value='�'>
							�<option value="" 
        DESIGNTIMESP=
4999							% 19891? DESIGNTIMESP="4735">
							%
							<option value='�'>
							�
							<option value='�'>
							�<option value="" 
        DESIGNTIMESP=
5002							$ DESIGNTIMESP="4738" 19894?>
							$
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�<option value="" 
        DESIGNTIMESP=
5008							@ DESIGNTIMESP="4744" 19900?>
							@
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='�'>
							�
							<option value='&shy;'>
							&shy;
							<option value='&nbsp;'>
							nbsp</option>
						</select>
				<tr>
					<td colspan="2">
						<button type="button" class="iCWebControlsII" onclick='ReturnSelectedSymbol();' style="WIDTH: 47px" onFocus="this.blur()" ID="Button1" title="<%=Save%>" value="<%=Save%>"><%=Save%></button>
						<button type="button" class="iCWebControlsII" onclick='window.close();' style="WIDTH: 47px" onFocus="this.blur()" ID="Button2" title="<%=Cancel%>" value="<%=Cancel%>"><%=Cancel%></button> 
</FORM></td></tr>
			</table>
		</fieldset>
	</body>
</HTML>
