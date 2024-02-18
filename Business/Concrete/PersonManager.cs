using Business.Abstract;
using Entities.Concrete; 

namespace Business.Concrete
{

// Maske başvuru işlemlerinden sorumlu sınıf
    public class PersonManager : IApplicantService // PersonManager'in referansını tutabilmek için IApplicantService'i implemente etmesi gerekiyor.
    {
        public void ApplyForMask(Person person) 
        {
            
        }

        public List<Person> GetList() 
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
            // Burada kişinin bilgileri kontrol edilir ve geriye bool bir değer döner.
            // Bunu yapmak için bir mikroservis kullanılacak. 
            // microservis linki: https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx
            
        }

    }
}

// Not: Class'tan önce interfacein implemente edilmesi gerekiyor.
