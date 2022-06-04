using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Leyva_T3.Repositorio;
using Leyva_T3.Models;
using Leyva_T3.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Leyva_T3Testing.Controladores;

public class MascotaTest
{
    [Test]
    public void index()
    {
        //var mockCategorias = new Mock<IMascotaRespositorio>();
        //mockCategorias.Setup(x => x.Obtener1()).Returns(new List<Mascota>() { new Mascota() });
        //var controller = new MascotasController(mockCategorias.Object);
        //var result = (ViewResult)controller.Index();
        //Assert.IsNotNull(result);
        //Assert.IsNotNull(result.Model);

    }
}
