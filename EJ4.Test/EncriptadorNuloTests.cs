using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EJ4.Test
{
    public class EncriptadorNuloTests
    {

        [Fact]
        public void Test_Encriptar()
        {
            //ARRANGE
            var encriptadorNulo = new EncriptadorNulo();

            //ACT
            var result = encriptadorNulo.Encriptar("TALLER DE PROGRAMACION");

            //ASSERT
            Assert.Equal("TALLER DE PROGRAMACION", result);
        }

        [Fact]
        public void Test_Desencriptar()
        {
            //ARRANGE
            var encriptadorNulo = new EncriptadorNulo();

            //ACT
            var result = encriptadorNulo.Desencriptar("TALLER DE PROGRAMACION");

            //ASSERT
            Assert.Equal("TALLER DE PROGRAMACION", result);
        }

    }
}
