﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    using DesignPatterns.Creational.Builder.Producto;

    /// <summary>
    /// Builder concreto
    /// </summary>
    class NokiaN9Builder: CelularBuilder
    {
        public override void ConstruirPantalla()
        {
            Celular.Pantalla = new Pantalla("Pantalla de Nokia");           
        }

        public override void ConstruirTeclado()
        {
            Celular.Teclado = new Teclado("Teclado touch de Symbian");
        }

        public override void ConstruirCargador()
        {
            Celular.Cargador = new Cargador("Cargador de Nokia");
        }
    }
}
