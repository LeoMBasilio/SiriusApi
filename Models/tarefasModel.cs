﻿namespace SiriusApi.Models;

public class tarefasModel
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataConclusao { get; set; }
    public bool Concluido { get; set; }
}
