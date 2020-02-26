using System;

namespace MembroDeTimeScrum_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface FuncaoDeScrumMaster
    {
        void BlindarTime();
    }

    public interface FuncaoDeProductOwner
    {
        void PriorizarBacklog();
    }

    public interface FuncaoDeDev
    {
        void ImplementarFuncionalidades();
    }

    public class Dev : FuncaoDeDev
    {
        public void PriorizarBacklog() { }
        public void BlindarTime() { }

        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codando e tomando café compulsivamente!!");
        }
    }

    public class ScrumMaster : FuncaoDeScrumMaster
    {
        public void PriorizarBacklog() { }

        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!!!");
        }

        public void ImplementarFuncionalidades() { }
    }

    public class ProductOwner : FuncaoDeProductOwner
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando backlog com base nas minhas necessidades de negócio");
        }

        public void BlindarTime() { }
        public void ImplementarFuncionalidades() { }
    }
}
