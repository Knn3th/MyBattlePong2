﻿using MBP.Datos;
using MBP.EjeVertical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBP.Logica
{
    public class GestionarDispositivos
    {
        public bool actualizarDispositivo(int idDispositivo)
        {
            Dispositivo dispositivo = new Dispositivo();
            dispositivo.Id = idDispositivo;        // Asigna el id del dispositivo
            dispositivo.UltimaConexion = DateTime.Now;      // Asigna el tiempo en el que se hace la conexion
            return new GestionarDispositivosDatos().agregarDispositivo(dispositivo); // Agrega o actualiza el dispositivo
        }

        public bool verificarPresenciaDispositivo(int idDispositivo)
        {
            Dispositivo dispositivo = new GestionarDispositivosDatos().buscarDispositivo(idDispositivo);
            if (dispositivo != null)       // verifica si el dispositivo existe
            {
                if (dispositivo.UltimaConexion <= DateTime.Now) // Verifica que el dispositivo se encuentre concetado desde antes
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false; // Dispositivo no existe
            }
        }
    }
}
