using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> lista;
        public frmArticulos()
        {
            InitializeComponent();
        }      
        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Helper helper = new Helper();
                lista = negocio.listar();
                dgvArticulos.DataSource = lista;
                helper.ocultarColumna("Id", "Descripcion", "UrlImg", dgvArticulos);
                helper.mostrarImagen(lista[0].Urlimg, picboxArticulo);
                txtDescripcion.Text = lista[0].Descripcion;
                txtPrecio.Text = "$" + lista[0].Precio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Categoria");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Precio");
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Helper helper = new Helper();
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo current = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    helper.mostrarImagen(current.Urlimg, picboxArticulo);
                    txtDescripcion.Text = current.Descripcion;
                    txtPrecio.Text = "$" + current.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoArticulo frmAgregar = new frmNuevoArticulo();
            frmAgregar.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo;
                if(dgvArticulos.CurrentRow != null)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmNuevoArticulo frmModificar = new frmNuevoArticulo(articulo);            
                    frmModificar.ShowDialog();
                    cargar();
                }
                else
                    MessageBox.Show("Por favor seleccione un artículo de la tabla.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo;
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    DialogResult resultado = MessageBox.Show("El archivo será eliminado. \r\n¿Desea continuar?", "Eliminar...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminarLogico(articulo.Id);
                        MessageBox.Show("Eliminado con éxito.");
                        cargar();
                    }
                }
                else
                    MessageBox.Show("Por favor seleccione un artículo de la tabla.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            Helper helper = new Helper();
            string filtro = txtFiltro.Text;

            if(filtro.Length >= 3)
            {
                listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = lista;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            helper.ocultarColumna("Id", "Descripcion", "UrlImg", dgvArticulos);
        }
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
               
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            Helper helper = new Helper();
            lblErrorCampo.Visible = false;
            lblErrorCriterio.Visible = false;
            lblErrorFiltro.Visible = false;

            if (cbxCampo.SelectedIndex < 0)
            {
                lblErrorCampo.Visible = true;
                lblErrorCriterio.Visible = true;
                lblErrorFiltro.Visible = true;
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                lblErrorCriterio.Visible = true;
                lblErrorFiltro.Visible = true;
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {                   
                    lblErrorFiltro.Visible = true;
                    return true;
                }
                if(!(helper.soloNumeros(txtFiltroAvanzado.Text)))
                {
                    lblErrorFiltro.Visible = true;
                    MessageBox.Show("Solo se admiten números en este campo.");
                    return true;
                }
            }
            return false;
        }
       
    }
}
