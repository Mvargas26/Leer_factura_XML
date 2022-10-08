using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1_Michael_Vargas_Punto_1_y_2
{
    internal class cl_Factura_Electronica
    {
        public string Clave;
        public string CodigoActividad;
        public string NumeroConsecutivo;
        public string FechaEmision;
        public string CondicionVenta;
        public string MedioPago;

        //Emisor
        public string Nombre;
        public string ide_Tipo;
        public string ide_Numero;

        public string ubi_Provincia;
        public string ubi_Canton;
        public string ubi_Distrito;
        public string ubi_Barrio;
        public string ubi_OtrasSenas;

        public string tel_CodigoPais;
        public string NumTelefono;

        public string CorreoElectronico;

        //RECEPTOR
        public string rec_Nombre;
        public string rec_ide_Tipo;
        public string rec_ide_Numero;
        public string rec_CorreoElectronico;


        //Detalle Servicio
        public List<cl_LineaDetalle> ds_Lineas = new List<cl_LineaDetalle>();

        //Resumen Factura
        public string resuFact_CodTipoMoneda_CodigoMoneda;
        public string resuFact_CodTipoMoneda_TipoCambio;

        public string resuFact_TotalServGravados;
        public string resuFact_TotalServExentos;
        public string resuFact_TotalMercanciasGravadas;
        public string resuFact_TotalMercanciasExentas;
        public string resuFact_TotalGravado;
        public string resuFact_TotalExento;
        public string resuFact_TotalVenta;
        public string resuFact_TotalDescuentos;
        public string resuFact_TotalVentaNeta;
        public string resuFact_TotalImpuesto;
        public string resuFact_TotalComprobante;

        //Otros
        public string OtroTexto;


    }//fin class

    public class cl_LineaDetalle
    {
        public string dtll_numLinea;

        public string dtll_codComer_Tipo;
        public string dtll_codComer_Codigo;

        public string dtll_Cantidad;
        public string dtll_unidadMedida;
        public string dtll_Detalle;
        public string dtll_PrecioUnita;
        public string dtll_MontoTotal;
        public string dtll_SubTotal;
        public string dtll_MontoTotalLinea;

        public string dtll_Des_MontoDescuento;
        public string dtll_Des_NaturalDescuento;

        public string dtll_Imp_Codigo;
        public string dtll_Imp_CodigoTarifa;
        public string dtll_Imp_Tarifa;
        public string dtll_Imp_Monto;

        public string dtll_Imp_ImpuestoNeto;
    }//fin DetalleServicio

}//fin space
