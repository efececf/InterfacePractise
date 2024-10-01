using InterfacePractise.Interfaces;

namespace InterfacePractise.Models
{
    public class CompanyFactory
    {
        public IWork getWorkType(String type)//Iwork yerine company yazsan da olurdu
        {
            if (type == null)
            {
                return null;
            }
            else if (type == "remote")
            {
                return new CompanyRemote();
            }
            else
            {
                return new CompanyFace();
            }
        }
    }
}
