using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Server.Context;
using BlazorApp1.Shared.Models;
using System;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivoController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Respuesta<Activo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Activos
                    .Where(x => x.Id == id)
                    .First();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Activo>> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Activos.ToList(); 
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(Activo model)
        {
            Respuesta<Activo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                Activo oActivo = new();

                oActivo.Marca = model.Marca;
                oActivo.Nombre = model.Nombre;
                oActivo.FechaIngreso = model.FechaIngreso;
                oActivo.Cantidad = model.Cantidad;
                

                db.Activos.Add(oActivo);
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(Activo model)
        {
            Respuesta<Activo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                Activo oActivo = db.Activos.Find(model.Id);

                oActivo.Marca = model.Marca;
                oActivo.Nombre = model.Nombre;
                oActivo.FechaIngreso = model.FechaIngreso;
                oActivo.Cantidad = model.Cantidad;
                

                db.Entry(oActivo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<Activo> oRespuesta = new();
            try
            {
                using DiMetalloContext db = new();

                Activo oActivo = db.Activos.Find(Id);
                db.Remove(oActivo);
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }
    }
}
