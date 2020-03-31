<%@ Page Title="Reportes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="ReporteadorKardex.About" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <section id="main-content">
        <section class="wrapper">
            <br />
            <br />

    <h2><asp:Label class="control-label"  ID="lbReporte" runat="server" Text="Reportes:"></asp:Label><br /></h2>

    <asp:ListBox CssClass="list-group legend-list" ID="lstboxSPS" runat="server" Height="124px" Width="900px" AutoPostBack="True" OnSelectedIndexChanged="lstboxSPS_SelectedIndexChanged" style="min-width:100%;" Font-Size="Medium" Font-Italic="true" ForeColor="Navy">
        
        <asp:ListItem class ="list-group-item">1) CARRERAS EN UN CAMPUS</asp:ListItem>
        <asp:ListItem class ="list-group-item">2) MATERIAS ASIGNADAS A UNA CARRERA</asp:ListItem>
        <asp:ListItem class ="list-group-item">3) MAESTROS ASIGNADOS A UNA MATERIA</asp:ListItem>
        <asp:ListItem class ="list-group-item">4) MAESTROS POR ESTATUS EN UNA CARRERA</asp:ListItem>
        <asp:ListItem class ="list-group-item">5) ALUMNOS ASIGNADOS POR MATERIA</asp:ListItem>
        <asp:ListItem class ="list-group-item">6) ALUMNOS EN UNA CARRERA POR ESTATUS</asp:ListItem>
        <asp:ListItem class ="list-group-item">7) CALIFICACIONES POR ALUMNO DE TODAS LAS MATERIAS</asp:ListItem>
        <asp:ListItem class ="list-group-item">8) CALIFICACIONES DE ALUMNO POR MATERIA Y PERIODO</asp:ListItem>
        <asp:ListItem class ="list-group-item">9) HORARIO DE UN MAESTRO</asp:ListItem>
        <asp:ListItem class ="list-group-item">10) HORARIO DE UN ALUMNO</asp:ListItem>
        <asp:ListItem class ="list-group-item">11) HORARIO DE UN GRUPO</asp:ListItem>
    </asp:ListBox><br />

            <br />
            <br />
          
            <br />
            <br />
            

    <asp:Panel ID="Panel1" runat="server" Height="46px" Visible="False">
        <div style="display:flex;">
            
           
             <div style="float:left; margin-right:20px;">  
                <asp:Label ID="lbDDL1" runat="server" Text="Estatus - Alumno: " Font-Size ="Larger" Font-Bold="true">   </asp:Label>
                    <asp:DropDownList ID="DDL1" runat="server" Width="150px" Font-Bold="true" Font-Size="Small" >
                    <asp:ListItem >Activo</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                </asp:DropDownList>
           </div>

             <div style="float:left; margin-right:20px;">  
                <asp:Label ID="lbDDL2" runat="server" Text="Estatus - Periodo: " Font-Size ="Larger" Font-Bold="true">   </asp:Label>
                    <asp:DropDownList ID="DDL2" runat="server" Width="150px" Font-Bold="true" Font-Size="Small" >
                    <asp:ListItem >Activo</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                </asp:DropDownList>
           </div>


            <div style="float:left; margin-right:20px;">
                <asp:Label ID="lb1" runat="server" Text="Label" Font-Bold="true" Font-Size="Larger"></asp:Label><br />
                <asp:TextBox ID="txt1" runat="server" Width="200px"></asp:TextBox>
            </div>
            <div style="float:left; margin-right:20px;">
                <asp:Label ID="lb2" runat="server" Text="Label" Font-Bold="true" Font-Size="Larger"></asp:Label><br />
                <asp:TextBox ID="txt2" runat="server" Width="200px"></asp:TextBox>
            </div>
            <div style="float:left; margin-right:20px;">
                <asp:Label ID="lb3" runat="server" Text="Label" Font-Bold="true" Font-Size="Larger"></asp:Label><br />
                <asp:TextBox ID="txt3" runat="server" Width="200px"></asp:TextBox>
            </div>
            <div style="float:left; margin-right:20px;">
                <asp:Label ID="lb4" runat="server" Text="Label" Font-Bold="true" Font-Size="Larger"></asp:Label><br />
                <asp:TextBox ID="txt4" runat="server" Width="200px"></asp:TextBox>
            </div>
        </div>
        
    </asp:Panel>

<br />
            <br />
            <br />
            <center>
    <asp:Button CssClass="btn btn-primary" ID="btnConsultar" runat="server" Text="Consultar" Width="157px" OnClick="btnConsultar_Click" Visible="False" />
      </center>
            <br />
            <br />
            <br />


             <style>
                table.table_class tbody  tr th  
                {
                 text-align:center !important;
                }

 </style>
        
     <asp:GridView  CssClass="table_class" ID="gvReportes" runat="server" HorizontalAlign="Center" Height="350px" Width="900px" CellPadding="4"  Font-Bold="True" Font-Names="Consolas" Font-Size="Small" Font-Strikeout="False" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" HorizontalAlign="Center" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" HorizontalAlign="Center"/>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"/>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle ForeColor="#333333" BackColor="#F7F6F3" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
     </asp:GridView>
    
    <p>
    </p>
            <center>
            <asp:Button ID="btnExportar" runat="server" BorderColor="#666699" BorderStyle="Ridge" CssClass="btn active" Font-Bold="True" Font-Names="Cambria" Font-Size="Large" ForeColor="#FF0066" OnClick="btnExportar_Click" Text="Exportar" Visible="False" />
                </center>
            </section>
    </section>
</asp:Content>


