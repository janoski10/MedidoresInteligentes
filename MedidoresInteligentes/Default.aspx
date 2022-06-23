<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresInteligentes.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="NumMedidor">Numero de Medidor</label>
                        <asp:DropDownList ID="NumMedidorDdl" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="Fecha">Fecha de la Lectura</label>
                        <asp:Calendar ID="FechaC" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="HrsLectura">Hora de la lectura</label>
                        <asp:TextBox ID="HrsLectura" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="MinLectura">Minutos de la lectura</label>
                        <asp:TextBox ID="MinLectura" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ValConsumo">Valor del Consumo</label>
                        <asp:TextBox ID="ValConsumo" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button runnat="server" ID="agregarBtn" OnClick="agregarBtn_Click" Text="Agregar" CssClass="btn btn-primary btn-lg"/>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
