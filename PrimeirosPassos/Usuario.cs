﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos;

public class Usuario
{
    public string Email;
    public string Senha;
    public string Nome;

    public Usuario()
    {
        
    }
    
    public Usuario(string nome)
    {
        Nome = nome;
    }

    public virtual void Logar()
    {
        Console.WriteLine("Usuário logado !");
    }
}
