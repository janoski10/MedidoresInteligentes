<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresInteligentes.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
          <div class="col-lg=6 mx-auto">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="tipoDdl"> Filtrar por Tipo: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipoDdl_SelectedIndexChanged" ID="tipoDdl" runat="server">
                            <asp:ListItem Value="1" Text="Inteligente"/>
                            <asp:ListItem Value="2" Text="Antiguo"/>
                        </asp:DropDownList>
                    </div>

                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Medidores" ShowHeader="true" 
                        AutoGenerateColumns="false" ID="grillaMedidor" 
                        runat="server">
                        <Columns>
                           <asp:BoundField DataField="id_medidor" HeaderText="Numero de Serie" />
                           <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                        </Columns>

                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>