﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WSClient.Tools
{
    public class SweetAlert
    {
        public static void Sweet_Alert(string title, string msg, string type, Page pg, Object obj)
        {
            string sa = "<script languaje='javascript'>" +
                "Swal.fire({" +
                    "title: '" + title + "'," +
                    "text: '" + msg + "'," +
                    "icon: '" + type + "'" +
                 "});" +
                "</script>";

            //Type hace referencia al tipo de objeto que voy a trabjaar
            Type cstype = obj.GetType();
            //ClientScriptManager me ayuda a incrustar bloques de código de JS en tiempo real dentro de Formulario Web Form de ASP
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, sa, sa);
        }

        public static void Sweet_Alert(string title, string msg, string type, Page pg, Object obj, string dir)
        {
            string sa = "<script languaje='javascript'>" +
                           "Swal.fire({" +
                           "title: '" + title + "'," +
                           "text: '" + msg + "'," +
                           "icon: '" + type + "'" +
                           "showCancelButton: true," +
                            "confirmButtonColor: '#3085d6'," +
                            "cancelButtonColor: '#d33'," +
                            "confirmButtonText: 'Yes, delete it!'" +

                           "}).then((result)=>{" +
                           "if(result.isConfirmed){" +
                           "window.location.href = '" + dir + "'" +
                           "}" +
                           "});" +
                           "</script>";

            //Type hace referencia al tipo de objeto que voy a trabjaar
            Type cstype = obj.GetType();
            //ClientScriptManager me ayuda a incrustar bloques de código de JS en tiempo real dentro de Formulario Web Form de ASP
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, sa, sa);
        }

    }//End sweetAlert
}//End namespace