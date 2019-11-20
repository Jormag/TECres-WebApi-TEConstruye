using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TECres_WebApi_TEConstruye.Controllers
{
    public class PropiedadController : ApiController
    {
        // GET api/Propiedad
        public IEnumerable<Propiedad> Get()
        {
            using (TECresEntities entities = new TECresEntities())
            {
                return entities.Propiedad.ToList();
            }
        }
        // GET api/Propiedad/IDPropiedad
        public Propiedad Get(int IDPropiedad)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                return entities.Propiedad.FirstOrDefault(controller => controller.IDPropiedad == IDPropiedad);
            }
        }

        // POST api/Propiedad
        public void Post([FromBody]Propiedad Propiedad)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                entities.Propiedad.Add(Propiedad);
                entities.SaveChanges();
            }
        }


        // PUT api/Propiedad/IDPropiedad
        public void Put(int IDPropiedad, [FromBody]Propiedad Propiedad)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                var entity = entities.Propiedad.FirstOrDefault(controller => controller.IDPropiedad == IDPropiedad);
                entity.Nombre = Propiedad.Nombre;
                entity.UbicacionPropiedad = Propiedad.UbicacionPropiedad;
                entity.Descripcion = Propiedad.Descripcion;
                entity.Habitaciones = Propiedad.Habitaciones;
                entity.Baños = Propiedad.Baños;
                entity.AreaTerreno = Propiedad.AreaTerreno;
                entity.AreaConstruccion = Propiedad.AreaConstruccion;
                entity.Dueño = Propiedad.Dueño;
                entity.TipoInmueble = Propiedad.TipoInmueble;
                entity.TipoPisoProp = Propiedad.TipoPisoProp;
                entity.Parqueos = Propiedad.Parqueos;
                entity.Gimnasio = Propiedad.Gimnasio;
                entity.Piscina = Propiedad.Piscina;
                entity.ParqueoVisitas = Propiedad.ParqueoVisitas;
                entity.Precio = Propiedad.Precio;
                entity.Foto1 = Propiedad.Foto1;
                entity.Foto2 = Propiedad.Foto2;
                entity.Foto3 = Propiedad.Foto3;
                entity.Foto4 = Propiedad.Foto4;
                entity.Foto5 = Propiedad.Foto5;

                entities.SaveChanges();
            }
        }

        // DELETE api/Propiedad/IDPropiedad
        public void Delete(int IDPropiedad)
        {
            using (TECresEntities entities = new TECresEntities())
            {
                entities.Propiedad.Remove(entities.Propiedad.FirstOrDefault(controller => controller.IDPropiedad == IDPropiedad));
                entities.SaveChanges();
            }
        }
    }
}
