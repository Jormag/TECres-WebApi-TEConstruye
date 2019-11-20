using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TECres_WebApi_TEConstruye.Controllers
{
    public class ClienteController : ApiController
    {
        // GET api/Cliente
        public IEnumerable<Cliente> Get()
        {
            using (TECresEntities entities = new TECresEntities())
            {
                return entities.Cliente.ToList();
            }
        }
        // GET api/Cliente/Cedula
        public Cliente Get(int Cedula)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                return entities.Cliente.FirstOrDefault(controller => controller.Cedula == Cedula);
            }
        }

        // POST api/Cliente
        public void Post([FromBody]Cliente cliente)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                entities.Cliente.Add(cliente);
                entities.SaveChanges();
            }
        }


        // PUT api/Cliente/Cedula
        public void Put(int Cedula, [FromBody]Cliente cliente)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                var entity = entities.Cliente.FirstOrDefault(controller => controller.Cedula == Cedula);
                entity.Nombre = cliente.Nombre;
                entity.Apellido1 = cliente.Apellido1;
                entity.Apellido2 = cliente.Apellido2;
                entity.Telefono = cliente.Telefono;
                entity.FechaNacimiento = cliente.FechaNacimiento;
                entity.Nacionalidad = cliente.Nacionalidad;
                entity.UbicacionUsuario = cliente.UbicacionUsuario;
                entity.Ingresos = cliente.Ingresos;
                entity.Ocupacion = cliente.Ocupacion;
                entity.Correo = cliente.Correo;
                entity.Perfil = cliente.Perfil;
                entity.Usuario = cliente.Usuario;
                entity.Contraseña = cliente.Contraseña;

                entities.SaveChanges();
            }
        }

        // DELETE api/Cliente/Cedula
        public void Delete(int Cedula)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                entities.Cliente.Remove(entities.Cliente.FirstOrDefault(controller => controller.Cedula == Cedula));
                entities.SaveChanges();
            }
        }
    }
}

