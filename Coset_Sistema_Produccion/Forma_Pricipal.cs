using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;
namespace Coset_Sistema_Produccion
{
    public partial class Coset_Sistema_Produccion : Form
    {
        public static string Tipo_Usuario = "";
        public static string ip_addres_server = "";
        public static string password_server = "";
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public List<Requisicion> Requisiciones_disponibles = new List<Requisicion>();
        public Class_Requisiciones Class_Requisiciones = new Class_Requisiciones();
        public Coset_Sistema_Produccion()
        {
            InitializeComponent();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Materiales forma_Materiales = new Forma_Materiales();
            forma_Materiales.ShowDialog();

        }

        private void Coset_Sistema_Produccion_Load(object sender, EventArgs e)
        {
            Obten_configuracion_systema();

            Oculta_todos_los_Menus_al_inicio_de_sesion();
            toolStripStatusUsuario.Text = "No Usuario";
            
        }

        private void Obten_configuracion_systema()
        {
            StreamReader Archivo_configuracion_sistema = new StreamReader(@appPath + "\\" + "Configuracion.txt");
            try
            {
               
                while (!Archivo_configuracion_sistema.EndOfStream)
                {
                    if (Archivo_configuracion_sistema.ReadLine().Contains("ip"))
                    {
                        ip_addres_server = Archivo_configuracion_sistema.ReadLine();
                    }
                    if (Archivo_configuracion_sistema.ReadLine().Contains("password"))
                    {
                        password_server = Archivo_configuracion_sistema.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Archivo_configuracion_sistema.Close();
        }

        private void Oculta_todos_los_Menus_al_inicio_de_sesion()
        {
            Oculta_Menu_Administrativo();
            Oculta_Menu_Ingenieria();
            Oculta_Menu_Almacen();
            Oculta_Menu_Produccion();
            Oculta_Menu_reportes();
            Oculta_Menu_Compras();
        }

        private void Oculta_Menu_Compras()
        {
            comprastoolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_reportes()
        {
            reportesToolStripMenuItem.Enabled=false;
        }

        private void Oculta_Menu_Produccion()
        {
            produccionToolStripMenuItem.Enabled=false;
        }

        private void Oculta_Menu_Almacen()
        {
            almacenToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Ingenieria()
        {
            ingenieriaToolStripMenuItem.Enabled=false;
        }

        private void Oculta_Menu_Administrativo()
        {
            administrativoToolStripMenuItem.Enabled= false;
        }

        private void Muestra_Menus_Para_Usuarios_Administrativos()
        {
            Muestra_Menu_Administrativo();
            Muestra_Menu_Ingenieria();
            Muestra_Menu_Almacen();
            Muestra_Menu_Produccion();
            Muestra_Menu_reportes();
            Muestra_Menu_Compras();
            Muestra_Menus_de_Compras_Prohibidas_Para_Ingenieria();
            toolStripStatusUsuario.Text = "Administrativo";
        }

        private void Muestra_Menu_Compras()
        {
            comprastoolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_reportes()
        {
            reportesToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_Produccion()
        {
            produccionToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_Almacen()
        {
            almacenToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_Ingenieria()
        {
            ingenieriaToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_Administrativo()
        {
            administrativoToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menus_Para_Usuarios_Ingenieria()
        {
            Muestra_Menu_Ingenieria();
            Muestra_Menu_Almacen();
            Muestra_Menu_Compras();
            Muestra_Menu_Produccion();
            Oculta_Menus_de_Almacen_Prohibidas_Para_Ingenieria();
            Oculta_Menus_de_Compras_Prohibidas_Para_Ingenieria();
            toolStripStatusUsuario.Text = "Ingenieria";
        }

        private void Muestra_Menus_de_Compras_Prohibidas_Para_Ingenieria()
        {
            Muestra_Menu_compras_Proveedores();
            Muestra_Menu_Compras_Orden_De_Compra();
            Muestra_menu_comras_requisiciones_pendientes();
            
        }

        private void Muestra_menu_comras_requisiciones_pendientes()
        {
            verificarRequisicionesPendientesToolStripMenuItem.Enabled = true;
        }

        private void Oculta_Menus_de_Compras_Prohibidas_Para_Ingenieria()
        {
            Oculta_Menu_Compras_Orden_De_Compra();
            Oculta_Menu_Compras_Proveedores();
            Oculta_menu_compras_requisiciones_pendientes();

        }

        private void Oculta_menu_compras_requisiciones_pendientes()
        {
            verificarRequisicionesPendientesToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Compras_Proveedores()
        {
            proveedoresToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Compras_Orden_De_Compra()
        {
            ordenesDeCompraToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menus_de_Almacen_Prohibidas_Para_Ingenieria()
        {
            Oculta_Menu_Almacen_Entradas();
            Oculta_Menu_Almacen_Salidas();
            Oculta_Menu_Almacen_Materiales();
        }

        private void Oculta_Menu_Almacen_Materiales()
        {
            materialesToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Almacen_Proveedores()
        {
            proveedoresToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Almacen_Salidas()
        {
            salidaMaterialesToolStripMenuItem.Enabled = false;
        }

        private void Oculta_Menu_Almacen_Entradas()
        {
            entradaMaterialesToolStripMenuItem.Enabled = false;
        }

        private void salirDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oculta_todos_los_Menus_al_inicio_de_sesion();
            Muestra_Menus_de_Almacen_Proibidas_Para_Ingenieria();
            Muestra_Menus_de_Almacen_Proibidas_Para_Compras();
            Muestra__menu_inicio_de_usuario();
            toolStripStatusUsuario.Text = "No Usuario";
            
        }

        private void Muestra__menu_inicio_de_usuario()
        {
            iniciarUsuariotoolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menus_de_Almacen_Proibidas_Para_Compras()
        {
            Muestra_Menu_Compras_Orden_De_Compra();
        }

        private void Muestra_Menu_Compras_Orden_De_Compra()
        {
            ordenesDeCompraToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menus_de_Almacen_Proibidas_Para_Ingenieria()
        {
            Muestra_Menu_Almacen_Entradas();
            Muestra_Menu_Almacen_Salidas();
            Muestra_Menu_Almacen_Materiales();
        }

        private void Muestra_Menu_Almacen_Materiales()
        {
            materialesToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menu_Almacen_Entradas()
        {
            entradaMaterialesToolStripMenuItem.Enabled = true; 
        }

        private void Muestra_Menu_Almacen_Salidas()
        {
            salidaMaterialesToolStripMenuItem.Enabled = true; 
        }

       
        private void Muestra_Menu_compras_Proveedores()
        {
            proveedoresToolStripMenuItem.Enabled = true;
        }

        private void Muestra_Menus_Para_Usuarios_almacen()
        {
            Muestra_Menu_Almacen();
            Muestra_Menu_Compras();
            Oculta_Menus_de_Compras_Prohibidas_Para_Almacen();
            toolStripStatusUsuario.Text = "Almacen";
        }

        private void Oculta_Menus_de_Compras_Prohibidas_Para_Almacen()
        {
            Oculta_Menu_Compras_Orden_De_Compra();
        }

        private void usuarioProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Muestra_Menus_Para_Usuarios_produccion();


        }

        private void Muestra_Menus_Para_Usuarios_produccion()
        {
            Muestra_Menu_Produccion();
            toolStripStatusUsuario.Text = "Produccion";
        }

        private void SalirDeProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void IniciarUsuariotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicia_timer_busca_tipo_de_usuario();
            Limpia_tipo_de_usuario();
            Mustra_forma_seleccio_de_usuarios();
            Oculta_menu_inicio_de_usuario();
        }

        private void Oculta_menu_inicio_de_usuario()
        {
            iniciarUsuariotoolStripMenuItem.Enabled = false;
        }

        private void Mustra_forma_seleccio_de_usuarios()
        {
            Forma_Inicio_Usuario form_Inicio_Usuario = new Forma_Inicio_Usuario();
            form_Inicio_Usuario.ShowDialog();
        }

        private void Limpia_tipo_de_usuario()
        {
            Tipo_Usuario = "";
        }

        private void Inicia_timer_busca_tipo_de_usuario()
        {
            timertipoususraio.Enabled = true;
        }

        private void Timertipousuario_Tick(object sender, EventArgs e)
        {
            if (Tipo_Usuario != "")
            {
                timertipoususraio.Enabled = false;
                Configura_Menu_En_Base_Tipo_usuario();
            }
        }


        private void Configura_Menu_En_Base_Tipo_usuario()
        {
            if (Tipo_Usuario == "Administrativo"  || Tipo_Usuario == "Admin-Compras")
                Configura_menus_para_usuarios_adminstrativos();
            else if (Tipo_Usuario == "Ingenieria")
                Configura_menus_para_usuarios_ingenieria();
            else if (Tipo_Usuario == "Almacen")
                Configura_menus_para_usuarios_almacen();
            else if (Tipo_Usuario == "Produccion")
                Configura_menus_para_usuarios_produccion();

            
        }

        private void Revisa_por_reqisiciones_abiertas()
        {
            Requisiciones_disponibles = Class_Requisiciones.Adquiere_requisiciones_abiertas_disponibles_en_base_datos(
                Forma_Inicio_Usuario.Usuario_global.nombre_empleado);
            if (Requisiciones_disponibles.Count != 0)
            {
                Limpia_datagrid_requisiciones_abiertas();
                Aparece_combo_requisiciones_abiertas();
                Aparece_etiqueta_requisiciones_abiertas();
                Rellena_combo_requisiciones_abiertas();
            }
            else
            {
                Desaparece_combo_requisiciones_abiertas();
                Desaparece_etiqueta_requisiciones_abiertas();
            }
        }

        private void Limpia_datagrid_requisiciones_abiertas()
        {
            dataGridViewRequisicionesAbiertas.Rows.Clear();
        }

        private void Desaparece_etiqueta_requisiciones_abiertas()
        {
            labelREquisicionesAbiertas.Visible = false;
        }

        private void Desaparece_combo_requisiciones_abiertas()
        {
            dataGridViewRequisicionesAbiertas.Visible = false;
        }

        private void Aparece_etiqueta_requisiciones_abiertas()
        {
            labelREquisicionesAbiertas.Visible = true;
        }

        private void Aparece_combo_requisiciones_abiertas()
        {
            dataGridViewRequisicionesAbiertas.Visible = true;
        }

        private void Rellena_combo_requisiciones_abiertas()
        {
            foreach (Requisicion requisicion in Requisiciones_disponibles)
            {
                try
                {
                    dataGridViewRequisicionesAbiertas.Rows.Add(requisicion.Codigo, requisicion.Requisitor,
                        requisicion.Fecha);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Configura_menus_para_usuarios_produccion()
        {
            Muestra_Menus_Para_Usuarios_produccion();
        }

        private void Configura_menus_para_usuarios_almacen()
        {
            Muestra_Menus_Para_Usuarios_almacen();
        }

        private void Configura_menus_para_usuarios_ingenieria()
        {
            Muestra_Menus_Para_Usuarios_Ingenieria();
        }

        private void Configura_menus_para_usuarios_adminstrativos()
        {
            Muestra_Menus_Para_Usuarios_Administrativos();
            Revisa_por_reqisiciones_abiertas();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelClock.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestra_forma_empleados();
        }

        private void Muestra_forma_empleados()
        {
            Forma_Usuarios forma_Usuarios = new Forma_Usuarios();
            forma_Usuarios.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestra_forma_datos_generales();
        }

        private void Muestra_forma_datos_generales()
        {
            Forma_Datos_Generales Forma_datos_denerales = new Forma_Datos_Generales();
            Forma_datos_denerales.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Clientes forma_Clientes = new Forma_Clientes();
            forma_Clientes.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Proveedores forma_Proveedores = new Forma_Proveedores();
            forma_Proveedores.ShowDialog();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Cotizaciones forma_Cotizaciones = new Forma_Cotizaciones();
            forma_Cotizaciones.ShowDialog();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Proyectos forma_Proyectos = new Forma_Proyectos();
            forma_Proyectos.ShowDialog();
        }

        private void procesosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forma_Procesos forma_Procesos = new Forma_Procesos();
            forma_Procesos.ShowDialog();
        }

        private void requisicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Requisiciones forma_Requisiciones = new Forma_Requisiciones();
            forma_Requisiciones.ShowDialog();
        }

        private void timerRequisicionesAbiertas_Tick(object sender, EventArgs e)
        {
           
        }

        private void labelREquisicionesAbiertas_Click(object sender, EventArgs e)
        {
            Revisa_por_reqisiciones_abiertas();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Ordenes_Compra forma_Ordenes_Compra = new Forma_Ordenes_Compra();
            forma_Ordenes_Compra.ShowDialog();
        }

        private void verificarRequisicionesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revisa_por_reqisiciones_abiertas();
        }

        private void consultaMaterialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forma_Consulta_Materiales forma_Consulta_Materiales = new Forma_Consulta_Materiales();
            forma_Consulta_Materiales.ShowDialog();
        }

        private void entradaMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Entrada_Materiales forma_Entrada_Materiales = new Forma_Entrada_Materiales();
            forma_Entrada_Materiales.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salidaMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Salida_Materiales forma_Salida_Materiales = new Forma_Salida_Materiales();
            forma_Salida_Materiales.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma_Devolucion_Materiales forma_Devolucion_Materiales = new Forma_Devolucion_Materiales();
            forma_Devolucion_Materiales.ShowDialog();
        }
    }
}
