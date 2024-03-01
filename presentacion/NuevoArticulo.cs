using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace presentacion
{
    public partial class frmNuevoArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private string filePath = ConfigurationManager.AppSettings["imgs-articulos"];
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }
        public frmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    Helper helper = new Helper();
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImg.Text = articulo.Urlimg;
                    helper.mostrarImagen(articulo.Urlimg, picboxAgregar);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ArticuloNegocio negocio = new ArticuloNegocio();
            Helper helper = new Helper();
            try
            {
                if (!(txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtUrlImg.Text != "" && txtPrecio.Text != ""))
                {
                    MessageBox.Show("Por favor llena todos los campos...");
                    return;
                }
                if (!(helper.soloNumeros(txtPrecio.Text)))
                {
                    MessageBox.Show("Solo se admiten números en el campo 'Precio'.");
                    return;
                }
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Urlimg = txtUrlImg.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    modificarArticulo();
                }
                else
                {
                    agregarArticulo();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            helper.mostrarImagen(txtUrlImg.Text, picboxAgregar);
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                Helper helper = new Helper();
                archivo.Filter = "jpg|*.jpg;|png|*.png";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtUrlImg.Text = archivo.FileName;
                    helper.mostrarImagen(archivo.FileName, picboxAgregar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guardarImagen()
        {
            File.Copy(archivo.FileName, filePath + archivo.SafeFileName);
        }

        private bool reemplazarImagen()
        {
            DialogResult resultado = MessageBox.Show("Ya existe un archivo con ese nombre. \n\r¿Desea reemplazarlo?", "Guardar...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                File.Copy(archivo.FileName, filePath + archivo.SafeFileName, true);
                return true;
            }
            else
                return false;
        }

        private void agregarArticulo()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (archivo != null && !(txtUrlImg.Text.ToLower().Contains("http")))
                {
                    if (File.Exists(filePath + archivo.SafeFileName) == true)
                    {
                        if (reemplazarImagen() == true)
                        {
                            negocio.agregar(articulo);
                            MessageBox.Show("Artículo agregado con éxito.");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        guardarImagen();
                        negocio.agregar(articulo);
                        MessageBox.Show("Artículo agregado con éxito.");
                    }
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void modificarArticulo()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (archivo != null && !(txtUrlImg.Text.ToLower().Contains("http")))
                {
                    if (File.Exists(filePath + archivo.SafeFileName) == true)
                    {
                        if (reemplazarImagen() == true)
                        {
                            negocio.modificar(articulo);
                            MessageBox.Show("Artículo modificado con éxito.");
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        guardarImagen();
                        negocio.modificar(articulo);
                        MessageBox.Show("Artículo modificado con éxito.");
                    }
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
