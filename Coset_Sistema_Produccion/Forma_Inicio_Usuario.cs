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

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Inicio_Usuario : Form
    {
        
        public List<Usuario> usuarios_disponibles = new List<Usuario>();
        public Class_Usuarios clase_usuarios = new Class_Usuarios();
        public static Usuario Usuario_global = null;
        public Forma_Inicio_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Inicio_Usuario_Load(object sender, EventArgs e)
        {
            Obtener_datos_usuarios_disponibles_base_datos();
            Rellena_comboBoxUsuarios_usando_Base_De_Datos();
            Oculta_boton_acceptar_hasta_selecccion_de_usuario();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxUsuarios.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUsuarios.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Obtener_datos_usuarios_disponibles_base_datos()
        {
            usuarios_disponibles = clase_usuarios.Adquiere_usuarios_disponibles_en_base_datos();
        }

        private void Oculta_boton_acceptar_hasta_selecccion_de_usuario()
        {
            CheckPassword.Enabled = false;
        }

        private void Rellena_comboBoxUsuarios_usando_Base_De_Datos()
        {
            foreach(Usuario usuario in usuarios_disponibles)
            {
                if (usuario.error == "")
                    comboBoxUsuarios.Items.Add(usuario.nombre_usuario);
                else
                {
                    MessageBox.Show(usuario.error);
                    break;
                }
                    
            }
        }

        private void CheckPassword_Click(object sender, EventArgs e)
        {
            Verifica_password_para_usuario_seleccionado();
        }

        private void Verifica_password_para_usuario_seleccionado()
        {
            Usuario_global = usuarios_disponibles.Find(usuario => usuario.nombre_usuario.Contains(comboBoxUsuarios.SelectedItem.ToString()));
            if (textBoxpassword.Text == Usuario_global.clave_usuario)
            {

                Coset_Sistema_Produccion.Tipo_Usuario = Usuario_global.tipo_empleado;
                Termina_instancia_Usuarios();
            }
            else
            {
                MessageBox.Show("Password Invalido","Password", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Termina_instancia_Usuarios()
        {
            usuarios_disponibles = null;
            clase_usuarios = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void comboBoxUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            Mueve_Cursor_Para_TextBox_password();
            Muestra_Boton_Aceptar_password();
        }

        private void Muestra_Boton_Aceptar_password()
        {
            CheckPassword.Enabled = true;
        }

        private void Mueve_Cursor_Para_TextBox_password()
        {
            textBoxpassword.Focus();
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Verifica_password_para_usuario_seleccionado();
            }
        }
    }
}
