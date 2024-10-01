using InterfacePractise.Models;

namespace InterfacePractise.Interfaces
{
    public class CompanyFace : Company, IWork
    {



        public void WorkStart()
        {
            Console.WriteLine("8 de ofise gelip işe başlayabilirsin");
        }
        public void WorkEnd()
        {
            Console.WriteLine("17 de ofisten çıkıp işi bitirebilirsin");
        }
    }
}
