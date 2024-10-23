using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos;

public class Aluno : Usuario
{
    public int Matricula;
    public decimal Media { get; private set; }
    private List<Materia> Materias;

    public Aluno() :base()
    {
        Materias = new List<Materia>();
    }

    public Aluno(string nome) :base(nome) 
    {
       
    }

    public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3)
    {
        decimal total = nota1 + nota2 + nota3;
        decimal media = total / 3;
    }

    public string AdicionarMateria(Materia materia)
    {
        foreach (Materia mate in Materias)
        {
            if (mate.Nome == materia.Nome)
                return "Essa matéria já existe.";
        }
        Materias.Add(materia);
        return "Matéria adicionada com sucesso.";
    }

    public override void Logar()
    {
        Console.WriteLine("Aluno logado ! !");
    }

}
