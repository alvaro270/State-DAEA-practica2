﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Apagado : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Switch apagado";
        }
    }
}
