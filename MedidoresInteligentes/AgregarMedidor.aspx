<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="AgregarMedidor.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
          <div class="col-lg=6 mx-auto">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="idTxt">Numero de Serie</label>
                        <asp:TextBox ID="idTxt" CssClass="form-control" runat="server" />
                        <asp:RequiredFieldValidator CssClass="text-danger" ControlToValidate="idTxt" ID="RequiredFieldValidator1" ErrorMessage=" Ingrese Nro de serie" runat="server"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipo_SelectedIndexChanged" ID="idTipo" runat="server">
                            <asp:ListItem Value="1" Text="Inteligente"/>
                            <asp:ListItem Value="2" Text="Antiguo"/>
                        </asp:DropDownList>
                    </div>

                    <asp:Button OnClick="addBtn_Click" ID="addBtn" Text="Agregar" runat="server" />

                </div>
            </div>
        </div>
    </div>
</asp:Content>