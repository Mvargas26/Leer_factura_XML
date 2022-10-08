using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    internal class cl_ProcesosXML
    {
        public cl_Factura_Electronica Leer_Factura()
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
                    mi_Factura.CodigoActividad = valor["CodigoActividad"].InnerText;
                    mi_Factura.NumeroConsecutivo = valor["NumeroConsecutivo"].InnerText;
                    mi_Factura.FechaEmision = valor["FechaEmision"].InnerText;
                    mi_Factura.CondicionVenta = valor["CondicionVenta"].InnerText;
                    mi_Factura.MedioPago = valor["MedioPago"].InnerText;
                    //emisor
                    mi_Factura.Nombre = valor["Emisor"].ChildNodes[0].InnerText;

                    mi_Factura.ide_Tipo = valor["Emisor"].ChildNodes[1].ChildNodes[0].InnerText;//obt Tipo
                    mi_Factura.ide_Numero = valor["Emisor"].ChildNodes[1].ChildNodes[1].InnerText;// obt Numero

                    mi_Factura.ubi_Provincia = valor["Emisor"].ChildNodes[2].ChildNodes[0].InnerText;// obt Provincia
                    mi_Factura.ubi_Canton = valor["Emisor"].ChildNodes[2].ChildNodes[1].InnerText; // obt canton
                    mi_Factura.ubi_Distrito = valor["Emisor"].ChildNodes[2].ChildNodes[2].InnerText; // obt distr
                    mi_Factura.ubi_Barrio = valor["Emisor"].ChildNodes[2].ChildNodes[3].InnerText; // obt barrio
                    mi_Factura.ubi_OtrasSenas = valor["Emisor"].ChildNodes[2].ChildNodes[4].InnerText; // obt OtrasSenas

                    mi_Factura.tel_CodigoPais = valor["Emisor"].ChildNodes[3].ChildNodes[0].InnerText; // obt codpais
                    mi_Factura.NumTelefono = valor["Emisor"].ChildNodes[3].ChildNodes[1].InnerText; // obt numtelef
                    mi_Factura.CorreoElectronico = valor["Emisor"].ChildNodes[4].InnerText;


                    //receptor
                    mi_Factura.rec_Nombre = valor["Receptor"].ChildNodes[0].InnerText;
                    mi_Factura.rec_ide_Tipo = valor["Receptor"].ChildNodes[1].ChildNodes[0].InnerText;
                    mi_Factura.rec_ide_Numero = valor["Receptor"].ChildNodes[1].ChildNodes[1].InnerText;
                    mi_Factura.rec_CorreoElectronico = valor["Receptor"].ChildNodes[2].InnerText;

                    //DetalleServicio
                    XmlNodeList listaDetalles = valor["DetalleServicio"].ChildNodes;
                    foreach (XmlNode valor2 in listaDetalles)
                    {
                        cl_LineaDetalle new_Linea = new cl_LineaDetalle();
                        new_Linea.dtll_numLinea = valor2["NumeroLinea"].InnerText;
                        new_Linea.dtll_codComer_Tipo = valor2["CodigoComercial"].ChildNodes[0].InnerText;
                        new_Linea.dtll_codComer_Codigo = valor2["CodigoComercial"].ChildNodes[1].InnerText;
                        new_Linea.dtll_Cantidad = valor2["Cantidad"].InnerText;
                        new_Linea.dtll_unidadMedida = valor2["UnidadMedida"].InnerText;
                        new_Linea.dtll_Detalle = valor2["Detalle"].InnerText;
                        new_Linea.dtll_PrecioUnita = valor2["PrecioUnitario"].InnerText;
                        new_Linea.dtll_MontoTotalLinea = valor2["MontoTotal"].InnerText;
                        new_Linea.dtll_SubTotal = valor2["SubTotal"].InnerText;
                        new_Linea.dtll_MontoTotalLinea = valor2["MontoTotalLinea"].InnerText;

                        if (valor2["Descuento"] != null)
                        {
                            new_Linea.dtll_Des_MontoDescuento = valor2["Descuento"].ChildNodes[0].InnerText;
                            new_Linea.dtll_Des_NaturalDescuento = valor2["Descuento"].ChildNodes[1].InnerText;

                        }

                        if (valor2["Impuesto"] != null)
                        {
                            new_Linea.dtll_Imp_Codigo = valor2["Impuesto"].ChildNodes[0].InnerText;
                            new_Linea.dtll_Imp_CodigoTarifa = valor2["Impuesto"].ChildNodes[1].InnerText;
                            new_Linea.dtll_Imp_Tarifa = valor2["Impuesto"].ChildNodes[2].InnerText;
                            new_Linea.dtll_Imp_Monto = valor2["Impuesto"].ChildNodes[3].InnerText;
                        }

                        if (valor2["ImpuestoNeto"] != null)
                        {
                            new_Linea.dtll_Imp_ImpuestoNeto = valor2["ImpuestoNeto"].InnerText;
                        }


                        mi_Factura.ds_Lineas.Add(new_Linea);

                    }//fin del for each donde carga las lineas

                    //ResumenFactura
                    mi_Factura.resuFact_CodTipoMoneda_CodigoMoneda = valor["ResumenFactura"].ChildNodes[0].ChildNodes[0].InnerText;
                    mi_Factura.resuFact_CodTipoMoneda_TipoCambio = valor["ResumenFactura"].ChildNodes[0].ChildNodes[1].InnerText;

                    mi_Factura.resuFact_TotalServGravados = valor["ResumenFactura"].ChildNodes[1].InnerText;
                    mi_Factura.resuFact_TotalServExentos = valor["ResumenFactura"].ChildNodes[2].InnerText;
                    mi_Factura.resuFact_TotalMercanciasGravadas = valor["ResumenFactura"].ChildNodes[3].InnerText;
                    mi_Factura.resuFact_TotalMercanciasExentas = valor["ResumenFactura"].ChildNodes[4].InnerText;
                    mi_Factura.resuFact_TotalGravado = valor["ResumenFactura"].ChildNodes[5].InnerText;
                    mi_Factura.resuFact_TotalExento = valor["ResumenFactura"].ChildNodes[6].InnerText;
                    mi_Factura.resuFact_TotalVenta = valor["ResumenFactura"].ChildNodes[7].InnerText;
                    mi_Factura.resuFact_TotalDescuentos = valor["ResumenFactura"].ChildNodes[8].InnerText;
                    mi_Factura.resuFact_TotalVentaNeta = valor["ResumenFactura"].ChildNodes[9].InnerText;
                    mi_Factura.resuFact_TotalImpuesto = valor["ResumenFactura"].ChildNodes[10].InnerText;
                    mi_Factura.resuFact_TotalComprobante = valor["ResumenFactura"].ChildNodes[11].InnerText;

                    //otros
                    mi_Factura.OtroTexto = valor["Otros"].ChildNodes[0].InnerText;

                }//fn forech

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return (mi_Factura);

        }//fin lelr_factura



    }//fin class
}//fin space
