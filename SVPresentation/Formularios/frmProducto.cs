﻿using SVPresentation.Utilidades.Objetos;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Implementation;
using SVServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVRepository.Entities;

namespace SVPresentation.Formularios
{
    public partial class frmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        public frmProducto(ICategoriaService categoriaService, IProductoService productoService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
        }
        public void MostrarTab(string tabName)
        {
            var TabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };
            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }
        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.Listar(buscar);

            var listaVM = listaProductos.Select(item => new ProductoVM
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra.ToString("0.00"),
                PrecioVenta = item.PrecioCompra.ToString("0.00"),
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No" //hola cual es el error aca? esta subrayado en rojo
            }).ToList();

            dgvProductos.DataSource = listaVM;

            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvProductos.ImplementarConfiguracion("Editar");
            txbPrecioCompraNuevo.ValidarNumero();
            txbPrecioCompraEditar.ValidarNumero();
            txbPrecioVentaNuevo.ValidarNumero();
            txbPrecioVentaEditar.ValidarNumero();
            await MostrarProductos();
            OpcionCombo[] itemsHabilitado = new OpcionCombo[]
           {
                new OpcionCombo{Texto = "Si", Valor = 1},
                new OpcionCombo{Texto = "No", Valor = 0},
           };
            var listaCategoria = await _categoriaService.Listar();
            var items = listaCategoria
                .Where(item => item.Activo == 1)
                .Select(item => new OpcionCombo { Texto = item.Nombre, Valor = item.IdCategoria })
                .ToArray();

            cbbCategoriaNuevo.InsertarItems(items);
            cbbCategoriaEditar.InsertarItems(items);

            cbbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txbBuscar.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            MostrarTab(tabNuevo.Name);
            cbbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = "";
            txbDescripcionNuevo.Text = "";
            txbPrecioCompraNuevo.Text = "";
            txbPrecioVentaNuevo.Text = "";
            txbCantidadNuevo.Value = 0;
            cbbCategoriaNuevo.Select();

        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardaNuevo_Click(object sender, EventArgs e)
        {
            if (txbCodigoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo");
                return;
            }
            if (txbDescripcionNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion");
                return;
            }
            if (txbPrecioCompraNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de compra");
                return;
            }
            if (txbPrecioVentaNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de venta");
                return;
            }
            if (txbCantidadNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad");
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;
            //hay algun error en esta funcion? si ingreso "123....55" no muestra el messagebox show
            if (!decimal.TryParse(txbPrecioCompraNuevo.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraNuevo.Select();
                return;
            }
            if (!decimal.TryParse(txbPrecioVentaNuevo.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaNuevo.Select();
                return;
            }

            var objeto = new Producto
            {
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txbCodigoNuevo.Text.Trim(),
                Descripcion = txbDescripcionNuevo.Text.Trim(),
                PrecioCompra = precioCompra,
                Cantidad = Convert.ToInt32(txbCantidadNuevo.Value)
            };

            var respuesta = await _productoService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {

                var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;

                cbbCategoriaEditar.EstablecerValor(productoSeleccionado.IdCategoria);
                txbCodigoEditar.Text = productoSeleccionado.Codigo;
                txbDescripcionEditar.Text = productoSeleccionado.Descripcion;
                txbPrecioCompraEditar.Text = productoSeleccionado.PrecioCompra;
                txbPrecioVentaEditar.Text = productoSeleccionado.PrecioVenta;
                txbCantidadEditar.Value = productoSeleccionado.Cantidad;
                cbbHabilitado.EstablecerValor(productoSeleccionado.Activo);

                MostrarTab(tabEditar.Name);
                cbbCategoriaEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbCodigoEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo");
                return;
            }
            if (txbDescripcionEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion");
                return;
            }
            if (txbPrecioCompraEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de compra");
                return;
            }
            if (txbPrecioCompraEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de venta");
                return;
            }
            if (txbCantidadEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad");
                return;
            }

            decimal precioCompra = 0;
            decimal precioVenta = 0;
            //hay algun error en esta funcion? si ingreso "123....55" no muestra el messagebox show
            if (!decimal.TryParse(txbPrecioCompraEditar.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraEditar.Select();
                return;
            }
            if (!decimal.TryParse(txbPrecioVentaEditar.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaEditar.Select();
                return;
            }
            var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
            var objeto = new Producto
            {
                IdProducto = productoSeleccionado.IdProducto,
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaEditar.SelectedItem!).Valor },
                Codigo = txbCodigoEditar.Text.Trim(),
                Descripcion = txbDescripcionEditar.Text.Trim(),
                PrecioCompra = precioCompra,
                Cantidad = Convert.ToInt32(txbCantidadEditar.Value),
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            }; 

            var respuesta = await _productoService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
