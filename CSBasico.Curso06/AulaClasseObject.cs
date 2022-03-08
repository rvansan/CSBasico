using System;

namespace Aula06
{
    public class AulaClasseObject
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public AulaClasseObject(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


        public static void CalculaAulaClasseObject()
        {
            AulaClasseObject aulaClasseObject1 = new AulaClasseObject("Rafael", "Vansan");
            object aulaClasseObject2 = new AulaClasseObject("Rafael", "Vansan");
            Console.WriteLine(aulaClasseObject1);
            Console.WriteLine(aulaClasseObject2);

            Console.WriteLine(aulaClasseObject1 == aulaClasseObject2);
            Console.WriteLine(aulaClasseObject1.Equals(aulaClasseObject2));
        }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }

        public override bool Equals(object obj)
        {
            //AulaClasseObject aulaClasseObject = (AulaClasseObject)obj;
            AulaClasseObject outraAulaClasseObject = obj as AulaClasseObject;

            if (outraAulaClasseObject == null)
                return false;

            return Nome == outraAulaClasseObject.Nome;
        }

    }
}
