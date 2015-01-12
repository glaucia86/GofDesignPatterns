﻿namespace DesignPatterns.Structural.Decorator.Decorador
{
    using DesignPatterns.Structural.Decorator.Componente;

    //El PersonajeVolador es un PersonajeNormal decorado.
    public class PersonajeVolador: Personaje
    {
        Personaje personaje;

        public PersonajeVolador()
        {
            personaje = new PersonajeNormal();
        }

        //Puede ejecutar la habilidad del PersonajeNormal y además agregarle comportamiento adicional.
        public override string EjecutarHabilidad()
        {
            return personaje.EjecutarHabilidad() + " y volar";
        }  
    }
}
