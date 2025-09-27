using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmTiposdeExamen : Form
        
    {
        bool blnNuevo = true;
        public frmTiposdeExamen()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoExamen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el código de exámen", "Búsqueda de tipo de exámen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Busca la mat especificada y si la encuentra blnNuevo pasa a false.
            //Si no la encuentra debe permanecer en true.
            using (SqlConnection con = new SqlConnection())
            {
                //Abrir conexión
                // cadena de conexión o connection string: donde se tiene q conectar mi programa
                // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                //Abro conexión
                con.Open();


                //Representa el objeto que utiliza el SP para ejecutarse
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_TIPO_EXAMEN";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("CODTIP", txtCodigoExamen.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtCodigoExamen.Text = DatosAlumno["CODTIP"].ToString();
                            txtTipoExamen.Text = DatosAlumno["NOMTIP"].ToString();
                            
                            blnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la no se encontró el código de exámen ingresado", "Búsqueda de Tipo de Exámen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        blnNuevo = true;
                    }

                    DatosAlumno.Close();




                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCodigoExamen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el código de exámen", "Grabado de c;odigo de exámen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTipoExamen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para el tipo de exámen", "Grabado de tipo de exámen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (blnNuevo)//Si es un booleano no es necesario poner la asignación
            {
                // Conexión a la BDD
                //Declaro variable con tipo nombre = new..
                using (SqlConnection con = new SqlConnection())
                {
                    //Abrir conexión
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INS_TIPO_EXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCodigoExamen.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtTipoExamen.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCodigoExamen.Text = "";
                        txtTipoExamen.Text = "";


                    }
                }
            }
            else
            {
                //EDITAR REGISTRO
                using (SqlConnection con = new SqlConnection())
                {
                    //Abrir conexión
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UPD_ALUMNO";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCodigoExamen.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtTipoExamen.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCodigoExamen.Text = "";
                        txtTipoExamen.Text = "";
                       
                    }
                }

            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (blnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar este tipo de exámen?", "Borrar Tipo de exámen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes) //Si presionó el botón SI
                {
                    //Borro registro
                    using (SqlConnection con = new SqlConnection())
                    {
                        //Abrir conexión
                        // cadena de conexión o connect string: donde se tiene q conectar mi programa
                        // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                        con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                        //Conecto 
                        con.Open();

                        //Defino el comando que apunta a del_alumno
                        //Representa el objeto q vos queres usar en la BDD
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "DEL_TIPO_EXAMEN";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("CODTIP", txtCodigoExamen.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtCodigoExamen.Text = "";
                            txtTipoExamen.Text = "";

                            blnNuevo = true;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe buscar un alumno para poder borrarlo", "Borrado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmTiposdeExamen_Load(object sender, EventArgs e)
        {

        }
    }
}
