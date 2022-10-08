using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    public partial class frm_ModificarXML : Form
    {
        public frm_ModificarXML()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                XmlDocument DocXML = new XmlDocument();
                DocXML.Load("C:\\Users\\Michael\\Desktop\\Factura_Examen_XML.xml");

                XmlNode ultimoNodo = DocXML.DocumentElement.ChildNodes[8].LastChild;
                //tag del nodo linea detalle
                string xmlns = "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica";

                XmlNode LineaDetalle = DocXML.CreateElement("LineaDetalle", xmlns); //Principal

                XmlNode NumeroLinea = DocXML.CreateElement("NumeroLinea");

                XmlNode CodigoComercial = DocXML.CreateElement("CodigoComercial");// Van al Principal
                XmlNode Tipo = DocXML.CreateElement("Tipo");
                XmlNode Codigo = DocXML.CreateElement("Codigo");

                XmlNode Cantidad = DocXML.CreateElement("Cantidad");// Van al Principal
                XmlNode UnidadMedida = DocXML.CreateElement("UnidadMedida");// Van al Principal
                XmlNode Detalle = DocXML.CreateElement("Detalle");// Van al Principal
                XmlNode PrecioUnitario = DocXML.CreateElement("PrecioUnitario");// Van al Principal
                XmlNode MontoTotal = DocXML.CreateElement("MontoTotal");// Van al Principal

                XmlNode Descuento = DocXML.CreateElement("Descuento");// Van al Principal
                XmlNode MontoDescuento = DocXML.CreateElement("MontoDescuento");
                XmlNode NaturalezaDescuento = DocXML.CreateElement("NaturalezaDescuento");

                XmlNode SubTotal = DocXML.CreateElement("SubTotal");// Van al Principal

                XmlNode Impuesto = DocXML.CreateElement("Impuesto");// Van al Principal
                XmlNode Codigo_Impuesto = DocXML.CreateElement("Codigo");
                XmlNode CodigoTarifa = DocXML.CreateElement("CodigoTarifa");
                XmlNode Tarifa = DocXML.CreateElement("Tarifa");
                XmlNode Monto = DocXML.CreateElement("Monto");

                XmlNode ImpuestoNeto = DocXML.CreateElement("ImpuestoNeto");
                XmlNode MontoTotalLinea = DocXML.CreateElement("MontoTotalLinea");

                ////Agregamos los valores
                NumeroLinea.InnerText = txtNumLinea.Text;
               
                Tipo.InnerText = txtTipo.Text;
                Codigo.InnerText = txtCod.Text;

                Cantidad.InnerText = txtCant.Text;
                UnidadMedida.InnerText = txtUnidadMed.Text;
                Detalle.InnerText = txtDetalle.Text;
                PrecioUnitario.InnerText = txtPrecioUni.Text;
                MontoTotal.InnerText = txtMontoTotal.Text;

                MontoDescuento.InnerText = txtMontoDesc.Text;
                NaturalezaDescuento.InnerText = txtnaturalezaDesc.Text;

                SubTotal.InnerText = txtSubTotalDesc.Text;

                Codigo_Impuesto.InnerText = txtCodImpu.Text;
                CodigoTarifa.InnerText = txtCodTarifaImpu.Text;
                Tarifa.InnerText = txtTarifaImpu.Text;
                Monto.InnerText = txtMontoImpuesto.Text;

                ImpuestoNeto.InnerText = txtImpuestoNeto.Text;
                MontoTotalLinea.InnerText = txtMontoTotalLinea.Text;

                ///appen de los nodos mas peuqenos
                CodigoComercial.AppendChild(Tipo);
                CodigoComercial.AppendChild(Codigo);

                Descuento.AppendChild(MontoDescuento);
                Descuento.AppendChild(NaturalezaDescuento);

                Impuesto.AppendChild(Codigo_Impuesto);
                Impuesto.AppendChild(CodigoTarifa);
                Impuesto.AppendChild(Tarifa);
                Impuesto.AppendChild(Monto);

                //appen de los nodos al nodo hijo
                LineaDetalle.AppendChild(NumeroLinea);
                LineaDetalle.AppendChild(CodigoComercial);
                LineaDetalle.AppendChild(Cantidad);
                LineaDetalle.AppendChild(UnidadMedida);
                LineaDetalle.AppendChild(Detalle);
                LineaDetalle.AppendChild(PrecioUnitario);
                LineaDetalle.AppendChild(MontoTotal);
                LineaDetalle.AppendChild(Descuento);
                LineaDetalle.AppendChild(SubTotal);
                LineaDetalle.AppendChild(Impuesto);
                LineaDetalle.AppendChild(ImpuestoNeto);
                LineaDetalle.AppendChild(MontoTotalLinea);

                ////insertamos despues del ultimo nodo
                DocXML.DocumentElement.InsertAfter(LineaDetalle, ultimoNodo);

                DocXML.Save("C:\\Users\\Michael\\Desktop\\Factura_Examen_XML.xml");

                MessageBox.Show("Agregada la Linea de compra correctamente");
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No se puedo actualizar la factura");
            }
        }

        private void frm_ModificarXML_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument DocXML = new XmlDocument();
                DocXML.Load("C:\\Users\\Michael\\Desktop\\Factura_Examen_XML.xml");
                XmlNode ultimoNodo = DocXML.DocumentElement.ChildNodes[8].LastChild;
                txtNumLinea.Text = Convert.ToString(Convert.ToInt32(ultimoNodo.ChildNodes[0].InnerText) + 1);
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }//fin class
}//fin space
