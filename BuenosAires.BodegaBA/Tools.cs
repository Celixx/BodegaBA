//using BuenosAires.DataLayer;
//using BuenosAires.Model;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace BuenosAires.Tools
//{
//    public static class Tools
//    {
//        public static string NombreSistema = "Sistema Buenos Aires";

//        public static DataGridViewTextBoxColumn GetColumn(string nombreCampo, string titulo)
//        {
//            return new DataGridViewTextBoxColumn()
//            {
//                Name = nombreCampo,
//                DataPropertyName = nombreCampo,
//                HeaderText = titulo
//            };
//        }

//        public static void ConfigurarDataGridView(this DataGridView dgv, string columnas)
//        {
//            dgv.AutoGenerateColumns = false;
//            string[] keyValuePairs = columnas.Split(',');
//            var dgcols = new DataGridViewColumn[keyValuePairs.Count()];
//            int index = 0;
//            foreach (string pair in keyValuePairs)
//            {
//                string[] parts = pair.Split(':');
//                string fieldName = parts[0].Trim();
//                string headerText = parts[1].Trim();
//                dgcols[index] = GetColumn(fieldName, headerText);
//                index++;
//            }
//            dgv.Columns.AddRange(dgcols);
//            dgv.ReadOnly = true;
//            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dgv.MultiSelect = false;
//        }

//        public static void RefrescarYajustar(this DataGridView dgv)
//        {
//            dgv.Refresh();
//            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
//        }

//        public static string GetString(this DataGridViewRow fila, string nombreCampo)
//        {
//            return fila.Cells[nombreCampo].Value.ToString();
//        }

//        public static void SeleccionarId(this DataGridView dgv, string nombreCampoID, int id)
//        {
//            int indiceFilaSeleccionada = -1;
//            foreach (DataGridViewRow fila in dgv.Rows)
//            {
//                if (fila.Cells[nombreCampoID].Value.ToString() == id.ToString())
//                {
//                    indiceFilaSeleccionada = fila.Index;
//                    break;
//                }
//            }
//            if (indiceFilaSeleccionada != -1)
//            {
//                dgv.Rows[indiceFilaSeleccionada].Selected = true;
//            }
//        }

//        public static bool EsNumero(this TextBox textBox)
//        {
//            return int.TryParse(textBox.Text, out int result);
//        }
//        public static int ToInt(this TextBox textBox)
//        {
//            return int.Parse(textBox.Text);
//        }

//        public static bool MostrarError(this Form form, string mensaje)
//        {
//            MessageBox.Show(mensaje, NombreSistema, MessageBoxButtons.OK
//                , MessageBoxIcon.Exclamation);
//            return false;
//        }

//        public static bool ErrRequerido(this Form form, string nombreCampo)
//        {
//            MessageBox.Show($"{nombreCampo} es un campo requerido, por lo que debe tener un valor."
//                , NombreSistema, MessageBoxButtons.OK
//                , MessageBoxIcon.Exclamation);
//            return false;
//        }

//        public static bool ErrEntero(this Form form, string nombreCampo)
//        {
//            MessageBox.Show($"El campo {nombreCampo} debe ser un número entero."
//                , NombreSistema, MessageBoxButtons.OK
//                , MessageBoxIcon.Exclamation);
//            return false;
//        }

//        public static bool ErrAccionID(this Form form, string nombreCampo, string accion)
//        {
//            MessageBox.Show($"Para poder {accion} debe seleccionar un número entero con el {nombreCampo}."
//                , NombreSistema, MessageBoxButtons.OK
//                , MessageBoxIcon.Exclamation);
//            return false;
//        }

//        public static bool MostrarMensaje(this Form form, string mensaje)
//        {
//            MessageBox.Show(mensaje
//                , NombreSistema, MessageBoxButtons.OK
//                , MessageBoxIcon.Information);
//            return false;
//        }

//        public static void Limpiar(this Form form, TextBox[] textBoxs)
//        {
//            foreach (var textBox in textBoxs)
//            {
//                textBox.Text = "";
//            }
//        }

//        public static void SetText(this TextBox textBox, object valor)
//        {
//            textBox.Text = valor.ToString();
//        }

//        public static int ToIntOrDefault(this TextBox textBox)
//        {
//            return textBox.Text == "" ? -1 : textBox.ToInt();
//        }

//        public static void FocusToEnd(this TextBox textBox)
//        {
//            textBox.Focus();
//            textBox.Select(textBox.Text.Length, 0);
//        }

//        public static void CentrarVentana(this Form form)
//        {
//            form.StartPosition = FormStartPosition.CenterScreen;
//        }

//        public static bool CopiarPropiedades(object objetoOrigen, object objetoDestino)
//        {
//            if (objetoOrigen == null) return false;
//            Type tipo = null;
//            PropertyInfo[] propiedades = null;
//            tipo = objetoOrigen.GetType();
//            propiedades = tipo.GetProperties();
//            if (tipo.Name == "List`1")
//            {
//                foreach (var item in (IList)objetoOrigen)
//                {
//                    var newItem = Activator.CreateInstance(Type.GetType(item.GetType().BaseType.FullName + ", " + item.GetType().BaseType.Assembly));
//                    CopiarPropiedades(item, newItem);
//                    ((IList)objetoDestino).Add(newItem);
//                }
//            }
//            else
//            {
//                foreach (PropertyInfo propiedad in propiedades)
//                {
//                    try
//                    {
//                        PropertyInfo propInfo = objetoDestino.GetType().GetProperty(propiedad.Name);
//                        propInfo.SetValue(objetoDestino, propiedad.GetValue(objetoOrigen, null));
//                    }
//                    catch
//                    {
//                        /* Los valores que no se pueden asignar son ignorados */
//                    }
//                }
//            }

//            return true;
//        }

//        public static string PonerPuntoFinal(string texto)
//        {
//            texto = texto.Trim();
//            if (texto != "")
//            {
//                if (!texto.EndsWith("."))
//                {
//                    return texto + ".";
//                }
//            }
//            return texto;
//        }

//        public static string MensajeError(string mensajeGeneral, Exception ex)
//        {
//            var mensajeError = "";

//            if (mensajeGeneral.Trim() != "")
//            {
//                mensajeError += PonerPuntoFinal(mensajeGeneral);
//            }

//            if (ex != null)
//            {
//                if (ex.Message.Trim() != "")
//                {
//                    if (mensajeError == "")
//                    {
//                        mensajeError = PonerPuntoFinal(ex.Message);
//                    }
//                    else
//                    {
//                        mensajeError += " " + PonerPuntoFinal(ex.Message);
//                    }
//                }

//                if (ex.InnerException != null)
//                {
//                    if (mensajeError == "")
//                    {
//                        mensajeError = PonerPuntoFinal(ex.InnerException.Message);
//                    }
//                    else
//                    {
//                        mensajeError += " " + PonerPuntoFinal(ex.InnerException.Message);
//                    }
//                }
//            }

//            if (mensajeError == "")
//            {
//                return "ERROR: Comuníquese con el Administrador del Sistema.";
//            }
//            else
//            {
//                return mensajeError + " Comuníquese con el Administrador del Sistema.";
//            }
//        }

//    }
//}
