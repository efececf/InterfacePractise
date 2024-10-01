using InterfacePractise.Models;

namespace InterfacePractise.Interfaces
{
    public class CompanyRemote : Company, IWork
    {

        public void WorkStart()
        {
            Console.WriteLine("8 de bilgisayarı açıp işe başlayabilirsin");
        }
        public void WorkEnd()
        {
            Console.WriteLine("17 de bilgisayarı kapayıp işi bitirebilirsin");
        }
    }
}
