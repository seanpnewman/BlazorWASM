using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BlazorWASMproj.Shared.Models
{ 
    public class Configurator
    {
        public int ID { get; set; } = 0;

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
