using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace CarpinteriaBD
{
    public class Conexion 
    {
        public static int ROL;
        public static string userR;
        public static string passwordR;

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id= '"+userR+"'; Password = '"+passwordR+"'; Database = carpinteria");
        
        public void conectar()
        {
            conn.Open();

        }

        public void desconectar()
        {
            conn.Close();
        }

        public DataTable ConsultaP()
        {
            try
            {
                conn.Open();
                string query = "select * from proveedores";
                NpgsqlCommand conectorP = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
                DataTable tabla = new DataTable();
                datosP.Fill(tabla);
                return tabla;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ConsultaC()
        {
            try {
                string query = "select * from clientes";
                NpgsqlCommand conectorP = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
                DataTable tabla = new DataTable();
                datosP.Fill(tabla);
                return tabla;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Login(string user, string pass)
        {
            userR = user;
            passwordR = pass;
            NpgsqlConnection connL = new NpgsqlConnection("Server=localhost;User Id= '" + userR + "'; Password = '" + passwordR + "'; Database = carpinteria");
            connL.Open();
            string bandera = "select nombre_usuario, pass from usuarios where nombre_usuario='" + user+ "' and pass='"+pass+"'";
            NpgsqlCommand conectorP = new NpgsqlCommand(bandera, connL);

            NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
            DataTable dt = new DataTable();
            datosP.Fill(dt);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    string rol = "select * from usuarios where nombre_usuario='" + user + "' and rol_usuario = 'Admin'";
                    NpgsqlCommand roluser = new NpgsqlCommand(rol, connL);
                    NpgsqlDataAdapter datosR=new NpgsqlDataAdapter(roluser);
                    DataTable dtR = new DataTable();
                    datosR.Fill(dtR);

                    if (dtR.Rows.Count>0)
                    {
                        ROL = 1;
                        Form Form1 = new InterfazBD();
                        Form1.Show();
                        MessageBox.Show("Admin");

                    }
                    else
                    {
                        string rol2 = "select * from usuarios where nombre_usuario='" + user + "' and rol_usuario = 'Jefe'";
                        NpgsqlCommand roluser2 = new NpgsqlCommand(rol2, connL);
                        NpgsqlDataAdapter datosR2 = new NpgsqlDataAdapter(roluser2);
                        DataTable dtR2 = new DataTable();
                        datosR2.Fill(dtR2);
                        if (dtR2.Rows.Count > 0)
                        {
                            ROL = 2;
                            Form Form1 = new InterfazBD();
                            Form1.Show();
                        }
                        else
                        {
                            ROL = 0;
                            Form Form1 = new InterfazBD();
                            Form1.Show();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connL.Close();
            }
        }

        public void InsertarProveedor(string nombreP,string direccionP,string telefonoP,string correoP)
        {
            try
            {
                conn.Open();
                string query = "insert into proveedores(nombrep,direccionp,telefonop,correop) values ('" + nombreP + "','" + direccionP + "'," + telefonoP + ",'" + correoP + "')";
                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("Hecho!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertarCliente(string nombreC, string direccionC, string telefonoC, string correoC)
        {
            try
            {
                conn.Open();
                string query = "insert into clientes(nombrec,direccionc,telefonoc,correoc) values ('" + nombreC + "','" + direccionC + "'," + telefonoC + ",'" + correoC + "')";
                NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
                ejecutor.ExecuteNonQuery();
                MessageBox.Show("Hecho!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertarMadera(string tipoMadera, string tamano, double precioCompra, double precioVenta, int cantidad)
        {
            conn.Open();
            string query = "insert into maderas(tipomadera,tamaño,preciocompra,precioventa,cantidad) values ('" + tipoMadera + "','" + tamano + "','" + precioCompra + "','" + precioVenta + "','" + cantidad + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");
            conn.Close();
        }

        public void ActualizarMadera(int idMadera, string tipoMadera, string tamano, double precioCompra, double precioVenta, int cantidad)
        {
            conn.Open();
            string query = "update maderas set tipomadera = '"+tipoMadera+"', tamaño = '"+tamano+"', preciocompra = "+precioCompra+", precioventa = "+precioVenta+", cantidad = "+cantidad+" where idmadera = "+idMadera+" ";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");
            conn.Close();
        }

        public void eliminarMadera(int idMadera)
        {
            conn.Open();
            string query = "delete from maderas where idmadera = "+idMadera+" ";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");           
            conn.Close();

        }

        public void ModificarCliente(int idC, string nombreC, string direccionC, int telefonoC, string correoC)
        {
            conn.Open();
            string query = "update clientes set nombrec='"+nombreC+"',direccionc='"+direccionC+"',telefonoc='"+telefonoC+"',correoc='"+correoC+"' where idcliente = "+idC+" ";
            NpgsqlCommand conectorC = new NpgsqlCommand(query, conn);
            conectorC.ExecuteNonQuery();
            MessageBox.Show("Actualizado");
            conn.Close();
        }

        public void EliminarCliente(int idc)
        {
            conn.Open();
            string query = "delete from clientes  where idcliente = "+idc;
            NpgsqlCommand conectorC = new NpgsqlCommand(query, conn);
            conectorC.ExecuteNonQuery();
            MessageBox.Show("ELIMINADO");
            conn.Close();
        }

        public void ModificarProv(int idP, string nombreP, string direccionP, int telefonoP, string correoP)
        {
            conn.Open();
            string query = "update proveedores set nombrep='" + nombreP + "',direccionp='" + direccionP + "',telefonop='" + telefonoP + "',correop='" + correoP + "' where idproveedor = " + idP + " ";
            NpgsqlCommand conectorC = new NpgsqlCommand(query, conn);
            conectorC.ExecuteNonQuery();
            MessageBox.Show("Actualizado");
            conn.Close();
        }

        public void EliminarProv(int idP)
        {
            conn.Open();
            string query = "delete from proveedores  where idproveedor = " + idP;
            NpgsqlCommand conectorC = new NpgsqlCommand(query, conn);
            conectorC.ExecuteNonQuery();
            MessageBox.Show("ELIMINADO");
            conn.Close();
        }

        public DataTable ConsultaT()
        {
            try
            {
                conn.Open();
                string query = "select * from trabajos";
                NpgsqlCommand conectorP = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
                DataTable tabla = new DataTable();
                datosP.Fill(tabla);
                return tabla;
            }
            finally
            {
                conn.Close();
            }
        }

        public void IngresarT(string nombreC,string dateS, string dateE, string descripcion, int cantidad, double costo, string status, double total)
        {
            conn.Open();
            string query = "insert into trabajos(fecha_solicitud,fecha_entrega,descripcion,cantidad,costo,status,total) values ('" + dateS + "','" +dateE+ "','"+descripcion+"',"+cantidad+","+costo+",'"+status+"',"+total+")"             ;
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            string bandera = "select nombrec from clientes where nombrec='"+nombreC+"'";
            NpgsqlCommand conectorP = new NpgsqlCommand(bandera, conn);

            NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
            DataTable dt = new DataTable();
            datosP.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Trabajo Guardado");
                }
                else
                {
                    MessageBox.Show("No existe Cliente con ese nombre");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void registrarCompra(string proveedor, string fecha, double total)
        {
            conn.Open();
            string query = "insert into compras(idproveedor,fechacompra, totalcompra) values((select idproveedor from proveedores where nombrep = '"+proveedor+"'),'"+fecha+"','"+total+"')";
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            string bandera = "select nombrep from proveedores where nombrep='" + proveedor + "'";
            NpgsqlCommand conectorP = new NpgsqlCommand(bandera, conn);

            NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
            DataTable dt = new DataTable();
            datosP.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Compra Guardada");
                }
                else
                {
                    MessageBox.Show("No existe Proveedor con ese nombre");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void registrarVenta(string cliente, string fecha, double total)
        {
            conn.Open();
            string query = "insert into ventas(idcliente,fechaventa, totalventa) values((select idcliente from clientes where nombrec = '" + cliente + "'),'" + fecha + "','" + total + "')";
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            string bandera = "select nombrec from clientes where nombrec='" + cliente + "'";
            NpgsqlCommand conectorP = new NpgsqlCommand(bandera, conn);

            NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
            DataTable dt = new DataTable();
            datosP.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Venta Guardada");
                }
                else
                {
                    MessageBox.Show("No existe Cliente con ese nombre");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void registraDetalleCompra(int idMadera, double precioc, int cantidadc){
            conn.Open();
            string query = "insert into detallescompra(idcompra, idmadera, precioc, cantidad) values((SELECT MAX(idcompra) FROM compras), '"+idMadera+"','"+precioc+"','"+cantidadc+"')";
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void registraDetalleVenta(int idMadera, double preciov, int cantidadv)
        {
            conn.Open();
            string query = "insert into detallesventa(idventa, idmadera, preciov, cantidadv) values((SELECT MAX(idventa) FROM ventas), '" + idMadera + "','" + preciov + "','" + cantidadv + "')";
            NpgsqlCommand comando = new NpgsqlCommand(query, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ConsultaM()
        {
            string query = "select  idmadera as id, tipomadera as Madera, tamaño as Tamaño, preciocompra as Precio from maderas";
            NpgsqlCommand conectorP = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datosP = new NpgsqlDataAdapter(conectorP);
            DataTable tabla = new DataTable();

            datosP.Fill(tabla);
            DataColumn column = new DataColumn();

            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Cantidad";
            column.ReadOnly = false;
            column.DefaultValue = 0;
            tabla.Columns.Add(column);
            return tabla;
        }

        public DataTable detallesCompra()
        {
            string query = "select idcompra as id, (select nombrep from proveedores where idproveedor = compras.idproveedor) as proveedor,fechacompra as fecha,totalcompra as total from compras";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable detallesMadera()
        {
            string query = "select idmadera as id, tipomadera as madera, tamaño, preciocompra as PrecioCompra, precioventa as PrecioVenta, cantidad from maderas";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable detallesVenta()
        {
            string query = "select idventa as id, (select nombrec from clientes where idcliente = ventas.idcliente) as cliente,fechaventa as fecha,totalventa as total from ventas";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable muestraDetalleCompra(int id)
        {
            string query = "select (select tipomadera from maderas where idmadera = detallescompra.idmadera) as madera, (select tamaño from maderas where idmadera = detallescompra.idmadera),precioc as precio, cantidad from detallescompra where idcompra = '"+id+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable muestraDetalleVenta(int id)
        {
            string query = "select (select tipomadera from maderas where idmadera = detallesventa.idmadera) as madera, (select tamaño from maderas where idmadera = detallesventa.idmadera),preciov as precio, cantidadv from detallesventa where idventa = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public void ActualizarUser(int idUSer,string nombreUSer, string pass, string rol)
        {
            conn.Open();
            string query = "update usuarios set nombre_usuario = '" + nombreUSer + "', pass = '" + pass + "', rol_usuario = '" + rol + "' where id_usuario = " + idUSer + "";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");
            conn.Close();
        }

        public void eliminarUser(int idUser)
        {
            conn.Open();
            string query = "delete from usuarios where id_usuario = " + idUser+ " ";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Hecho!");
            conn.Close();

        }
    }
    
}
