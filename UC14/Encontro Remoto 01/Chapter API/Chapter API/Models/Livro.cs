﻿namespace Chapter_API.Models
{
    public class Livro
    {
        //propriedades da classe livro
        //modificador de acesso
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int QuantidadePaginas { get; set; }
        public bool Disponivel { get; set; }
    }
}
