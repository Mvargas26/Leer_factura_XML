using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    public partial class frmConsultar_XML : Form
    {
        public frmConsultar_XML()
        {
            InitializeComponent();
        }
        
        private void btnVer_Click(object sender, EventArgs e)
        {
            //objeto de tipo factura
            cl_Factura_Electronica mi_Factura = new cl_Factura_Electronica();
           
            XmlDocument docXML = new XmlDocument();
            try
            {
                docXML.Load("C:\\Users\\Michael\\Desktop\\Factura_Examen_XML.xml");

                //string strXML = docXML.OuterXml;


                XmlNodeList listNodosFactura = docXML.ChildNodes;

                foreach (XmlNode valor in listNodosFactura)
                {
                    mi_Factura.Clave = valor["Clave"].InnerText;
                    listDetalle.Items.Add("Clave-  "+mi_Factura.Clave);
                    mi_Factura.CodigoActividad = valor["CodigoActividad"].InnerText;
                    listDetalle.Items.Add("Codigo Actividad - " + mi_Factura.CodigoActividad);
                    mi_Factura.NumeroConsecutivo = valor["NumeroConsecutivo"].InnerText;
                    listDetalle.Items.Add("NumeroConsecutivo-  " + mi_Factura.NumeroConsecutivo);
                    mi_Factura.FechaEmision = valor["FechaEmision"].InnerText;
                    listDetalle.Items.Add("FechaEmision-  " + mi_Factura.FechaEmision);
                    mi_Factura.CondicionVenta = valor["CondicionVenta"].InnerText;
                    listDetalle.Items.Add("Condicion Venta-  " + mi_Factura.CondicionVenta);
                    mi_Factura.MedioPago = valor["MedioPago"].InnerText;
                    listDetalle.Items.Add("MedioPago-  " + mi_Factura.MedioPago);
                    //emisor
                    mi_Factura.Nombre = valor["Emisor"].ChildNodes[0].InnerText;
                    listDetalle.Items.Add("Nombre Emisor-  " + mi_Factura.Nombre);

                    mi_Factura.ide_Tipo= valor["Emisor"].ChildNodes[1].ChildNodes[0].InnerText;//obt Tipo
                    listDetalle.Items.Add("Tipo identificacion-  " + mi_Factura.ide_Tipo);
                    mi_Factura.ide_Numero = valor["Emisor"].ChildNodes[1].ChildNodes[1].InnerText;// obt Numero
                    listDetalle.Items.Add("Numero-  " + mi_Factura.ide_Numero);

                    mi_Factura.ubi_Provincia=valor["Emisor"].ChildNodes[2].ChildNodes[0].InnerText;// obt Provincia
                    listDetalle.Items.Add("Provincia-  " + mi_Factura.ubi_Provincia);
                    mi_Factura.ubi_Canton=valor["Emisor"].ChildNodes[2].ChildNodes[1].InnerText; // obt canton
                    listDetalle.Items.Add("Canton-  " + mi_Factura.ubi_Canton);
                    mi_Factura.ubi_Distrito=valor["Emisor"].ChildNodes[2].ChildNodes[2].InnerText; // obt distr
                    listDetalle.Items.Add("Distrito-  " + mi_Factura.ubi_Distrito);
                    mi_Factura.ubi_Barrio=valor["Emisor"].ChildNodes[2].ChildNodes[3].InnerText; // obt barrio
                    listDetalle.Items.Add("Barrio-  " + mi_Factura.ubi_Barrio);
                    mi_Factura.ubi_OtrasSenas=valor["Emisor"].ChildNodes[2].ChildNodes[4].InnerText; // obt OtrasSenas
                    listDetalle.Items.Add("Otras Señas-  " + mi_Factura.ubi_OtrasSenas);

                    mi_Factura.tel_CodigoPais=valor["Emisor"].ChildNodes[3].ChildNodes[0].InnerText; // obt codpais
                    listDetalle.Items.Add("Codigo Pais-  " + mi_Factura.tel_CodigoPais);
                    mi_Factura.NumTelefono=valor["Emisor"].ChildNodes[3].ChildNodes[1].InnerText; // obt numtelef
                    listDetalle.Items.Add("Num Telefono Emisor- " + mi_Factura.NumTelefono);
                    mi_Factura.CorreoElectronico = valor["Emisor"].ChildNodes[4].InnerText;
                    listDetalle.Items.Add("Correo Electronico  Emisor- " + mi_Factura.CorreoElectronico);


                    //receptor
                    mi_Factura.rec_Nombre = valor["Receptor"].ChildNodes[0].InnerText;
                    listDetalle.Items.Add("Nombre receptor-  " + mi_Factura.rec_Nombre);
                    mi_Factura.rec_ide_Tipo = valor["Receptor"].ChildNodes[1].ChildNodes[0].InnerText;
                    listDetalle.Items.Add("receptor Tipo identificacion-  " + mi_Factura.rec_ide_Tipo);
                    mi_Factura.rec_ide_Numero = valor["Receptor"].ChildNodes[1].ChildNodes[1].InnerText;
                    listDetalle.Items.Add("receptor ide Numero-  " + mi_Factura.rec_ide_Numero);
                    mi_Factura.rec_CorreoElectronico = valor["Receptor"].ChildNodes[2].InnerText;
                    listDetalle.Items.Add("receptor Correo Electronico-  " + mi_Factura.rec_CorreoElectronico);

                    //DetalleServicio
                    XmlNodeList listaDetalles = valor["DetalleServicio"].ChildNodes;
                    foreach (XmlNode valor2 in listaDetalles)
                    {
                        cl_LineaDetalle new_Linea = new cl_LineaDetalle();
                        new_Linea.dtll_numLinea = valor2["NumeroLinea"].InnerText;
                        listDetalle.Items.Add("numero Linea  -" + new_Linea.dtll_numLinea);
                       new_Linea.dtll_codComer_Tipo = valor2["CodigoComercial"].ChildNodes[0].InnerText;
                        listDetalle.Items.Add("Cod Tipo Comercio  -" + new_Linea.dtll_codComer_Tipo);
                        new_Linea.dtll_codComer_Codigo = valor2["CodigoComercial"].ChildNodes[1].InnerText;
                        listDetalle.Items.Add("Codigo Comericio  -" + new_Linea.dtll_codComer_Codigo);
                        new_Linea.dtll_Cantidad = valor2["Cantidad"].InnerText;
                        listDetalle.Items.Add("Cantidad  -" + new_Linea.dtll_Cantidad);
                        new_Linea.dtll_unidadMedida = valor2["UnidadMedida"].InnerText;
                        listDetalle.Items.Add("unidadMedida  -" + new_Linea.dtll_unidadMedida);
                        new_Linea.dtll_Detalle = valor2["Detalle"].InnerText;
                        listDetalle.Items.Add("Detalle  -" + new_Linea.dtll_Detalle);
                        new_Linea.dtll_PrecioUnita = valor2["PrecioUnitario"].InnerText;
                        listDetalle.Items.Add("Precio Unitario  -" + new_Linea.dtll_PrecioUnita);
                        new_Linea.dtll_MontoTotalLinea = valor2["MontoTotal"].InnerText;
                        listDetalle.Items.Add("Monto Total Linea  -" + new_Linea.dtll_MontoTotalLinea);
                        new_Linea.dtll_SubTotal = valor2["SubTotal"].InnerText;
                        listDetalle.Items.Add("Sub Total  -" + new_Linea.dtll_SubTotal);
                        new_Linea.dtll_MontoTotalLinea = valor2["MontoTotalLinea"].InnerText;
                        listDetalle.Items.Add("Monto Total Linea  -" + new_Linea.dtll_MontoTotalLinea);

                        if (valor2["Descuento"] != null)
                        {
                            new_Linea.dtll_Des_MontoDescuento= valor2["Descuento"].ChildNodes[0].InnerText;
                            listDetalle.Items.Add("Monto Descuento  -" + new_Linea.dtll_Des_MontoDescuento);
                            new_Linea.dtll_Des_NaturalDescuento = valor2["Descuento"].ChildNodes[1].InnerText;
                            listDetalle.Items.Add("Descuento Natural  -" + new_Linea.dtll_Des_NaturalDescuento);

                        }

                        if (valor2["Impuesto"] != null)
                        {
                            new_Linea.dtll_Imp_Codigo = valor2["Impuesto"].ChildNodes[0].InnerText;
                            listDetalle.Items.Add("Codigo Impuesto  -" + new_Linea.dtll_Imp_Codigo);
                            new_Linea.dtll_Imp_CodigoTarifa = valor2["Impuesto"].ChildNodes[1].InnerText;
                            listDetalle.Items.Add("Codigo Tarifa  -" + new_Linea.dtll_Imp_CodigoTarifa);
                            new_Linea.dtll_Imp_Tarifa = valor2["Impuesto"].ChildNodes[2].InnerText;
                            listDetalle.Items.Add("Tarifa Impuesto  -" + new_Linea.dtll_Imp_Tarifa);
                            new_Linea.dtll_Imp_Monto = valor2["Impuesto"].ChildNodes[3].InnerText;
                            listDetalle.Items.Add("Monto Impuesto  -" + new_Linea.dtll_Imp_Monto);
                        }

                        if (valor2["ImpuestoNeto"] != null)
                        {
                            new_Linea.dtll_Imp_ImpuestoNeto = valor2["ImpuestoNeto"].InnerText;
                            listDetalle.Items.Add("Impuesto Neto  -" + new_Linea.dtll_Imp_ImpuestoNeto);
                        }


                        mi_Factura.ds_Lineas.Add(new_Linea);

                    }//fin del for each donde carga las lineas

                    //ResumenFactura
                    mi_Factura.resuFact_CodTipoMoneda_CodigoMoneda = valor["ResumenFactura"].ChildNodes[0].ChildNodes[0].InnerText;
                    listDetalle.Items.Add("Codigo Moneda- " + mi_Factura.resuFact_CodTipoMoneda_CodigoMoneda);
                    mi_Factura.resuFact_CodTipoMoneda_TipoCambio = valor["ResumenFactura"].ChildNodes[0].ChildNodes[1].InnerText;
                    listDetalle.Items.Add("Tipo Cambio- " + mi_Factura.resuFact_CodTipoMoneda_TipoCambio);

                    mi_Factura.resuFact_TotalServGravados = valor["ResumenFactura"].ChildNodes[1].InnerText;
                    listDetalle.Items.Add("Total Serv Gravados- " + mi_Factura.resuFact_TotalServGravados);
                    mi_Factura.resuFact_TotalServExentos = valor["ResumenFactura"].ChildNodes[2].InnerText;
                    listDetalle.Items.Add("Total Serv Exentos- " + mi_Factura.resuFact_TotalServExentos);
                    mi_Factura.resuFact_TotalMercanciasGravadas = valor["ResumenFactura"].ChildNodes[3].InnerText;
                    listDetalle.Items.Add("Total Mercancias Gravadas- " + mi_Factura.resuFact_TotalMercanciasGravadas);
                    mi_Factura.resuFact_TotalMercanciasExentas = valor["ResumenFactura"].ChildNodes[4].InnerText;
                    listDetalle.Items.Add("Total Mercancias Exentas- " + mi_Factura.resuFact_TotalMercanciasExentas);
                    mi_Factura.resuFact_TotalGravado = valor["ResumenFactura"].ChildNodes[5].InnerText;
                    listDetalle.Items.Add("Total Gravado- " + mi_Factura.resuFact_TotalGravado);
                    mi_Factura.resuFact_TotalExento = valor["ResumenFactura"].ChildNodes[6].InnerText;
                    listDetalle.Items.Add("Total Exento- " + mi_Factura.resuFact_TotalExento);
                    mi_Factura.resuFact_TotalVenta = valor["ResumenFactura"].ChildNodes[7].InnerText;
                    listDetalle.Items.Add("Total Venta- " + mi_Factura.resuFact_TotalVenta);
                    mi_Factura.resuFact_TotalDescuentos = valor["ResumenFactura"].ChildNodes[8].InnerText;
                    listDetalle.Items.Add("Total Descuentos- " + mi_Factura.resuFact_TotalDescuentos);
                    mi_Factura.resuFact_TotalVentaNeta= valor["ResumenFactura"].ChildNodes[9].InnerText;
                    listDetalle.Items.Add("Total Venta Neta- " + mi_Factura.resuFact_TotalVentaNeta);
                    mi_Factura.resuFact_TotalImpuesto = valor["ResumenFactura"].ChildNodes[10].InnerText;
                    listDetalle.Items.Add("Total Impuesto- " + mi_Factura.resuFact_TotalImpuesto);
                    mi_Factura.resuFact_TotalComprobante = valor["ResumenFactura"].ChildNodes[11].InnerText;
                    listDetalle.Items.Add("Tota lComprobante- " + mi_Factura.resuFact_TotalComprobante);

                    //otros
                    mi_Factura.OtroTexto = valor["Otros"].ChildNodes[0].InnerText;
                    listDetalle.Items.Add("Otro Texto- " + mi_Factura.OtroTexto);


                }//fn forech



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//fin btn ver

        
    }//fin class

}//fin space
