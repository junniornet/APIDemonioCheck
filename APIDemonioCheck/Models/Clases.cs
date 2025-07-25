﻿namespace APIDemonioCheck.Models
{
    public class Discos
    {
        public string Nombre { get; set; }
        public string Total { get; set; }
        public string EnUso { get; set; }
        public string Libre { get; set; }
        public string Tipo { get; set; }
    }
    public class Maquina
    {
        public List<Discos> Discos { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string Dominio { get; set; }
    }
}
