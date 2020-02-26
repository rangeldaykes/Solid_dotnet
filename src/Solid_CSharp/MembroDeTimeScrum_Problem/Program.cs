using System;

namespace MembroDeTimeScrum_Problem
{
    /// <summary>
    /// PROBLEMAS
    /// Suponhamos que alguma alteração seja necessária no método 
    /// BlindarTime, que agora precisa receber alguns parâmetros.
    /// Dessa forma, somos obrigados a alterar todas implementações
    /// de MembroDeTimeScrum – Dev, ScrumMaster e ProductOwner – por causa 
    /// de uma mudança que deveria afetar apenas a classe ScrumMaster.
    ///
    /// Além disso, classes-cliente que dependiam de MembroDeTimeScrum 
    /// terão que ser recompiladas e se estão em diversos componentes 
    /// terão que ser redistribuídas.Algumas vezes desnecessariamente, 
    /// pois nem sequer faziam uso do método BlindarTime!
    ///
    /// Outro problema é que a implementação de métodos inúteis 
    /// (chamados “degenerados”) pode levar à violação do LSP, 
    /// pois alguém utilizando MembroDeTimeScrum poderia supor o seguinte:
    ///
    /// foreach(var membro in membrosDeTimeScrum)
    /// membro.ImplementarFuncionalidades();
    /// 
    /// No entanto, sabemos que apenas Dev executa o comportamento acima.
    /// Se a lista tivesse também objetos do tipo ScrumMaster ou ProductOwner, 
    /// esses objetos não estariam realizando nada, ou pior, poderiam 
    /// disparar alguma exceção, caso a implementação dos mesmos assim o fizesse.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface MembroDeTimeScrum
    {
        void PriorizarBacklog();
        void BlindarTime();
        void ImplementarFuncionalidades();
    }

    public class Dev : MembroDeTimeScrum
    {
        public void PriorizarBacklog() { }
        public void BlindarTime() { }

        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codando e tomando café compulsivamente!!");
        }
    }

    public class ScrumMaster : MembroDeTimeScrum
    {
        public void PriorizarBacklog() { }

        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!!!");
        }

        public void ImplementarFuncionalidades() { }
    }

    public class ProductOwner : MembroDeTimeScrum
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando backlog com base nas minhas necessidades de negócio");
        }

        public void BlindarTime() { }
        public void ImplementarFuncionalidades() { }
    }
}
