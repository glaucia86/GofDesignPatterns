﻿namespace DesignPatterns.Behavioral.Strategy.Contexto
{
    public class Pelea
    {
        EstrategiaContraataque estrategiaContraataque;

        public void DefinirEstrategiaContraataque(EstrategiaContraataque nuevaEstrategia)
        {
           estrategiaContraataque = nuevaEstrategia;
        }

        public string Contraatacar()
        {
            return estrategiaContraataque.Contraatacar(this);
        }
    }
}
