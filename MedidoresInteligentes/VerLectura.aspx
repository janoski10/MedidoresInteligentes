<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLectura.aspx.cs" Inherits="MedidoresInteligentes.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
          <div class="col-lg=6 mx-auto">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="selectMedidor"> Seleccione Medidors: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="selectMedidor_SelectedIndexChanged" ID="selectMedidor" runat="server" Height="16px" Width="146px">
                            <asp:ListItem Value="1" Text="Inteligente"/>
                            <asp:ListItem Value="2" Text="Antiguo"/>
                        </asp:DropDownList>
                        <asp:Button Text="Actualizar" runat="server" OnClick="Update" Width="90px" Height="25px" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
