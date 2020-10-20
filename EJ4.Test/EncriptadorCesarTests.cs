using System;
using Xunit;

namespace EJ4.Test
{
    public class EncriptadorCesarTests
    {
        [Fact]
        public void Test_Encriptar()
        {
            //ARRANGE
            var encriptadorCesar = new EncriptadorCesar(1);

            //ACT
            var cadenaEncriptada = encriptadorCesar.Encriptar("TALLER DE PROGRAMACION");

            //ASSERT
            Assert.Equal("UBMMFS EF QSPHSBNBDJP�", cadenaEncriptada);
        }

        [Fact]
        public void Test_Desencriptar()
        {
            //ARRANGE
            var encriptadorCesar = new EncriptadorCesar(1);

            //ACT
            var cadenaDesencriptada = encriptadorCesar.Desencriptar("UBMMFS EF QSPHSBNBDJP�");

            //ASSERT
            Assert.Equal("TALLER DE PROGRAMACION", cadenaDesencriptada);
        }
    }
}