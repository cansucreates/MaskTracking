using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager: ISupplierService // Maske gönderme işlemlerinden sorumlu sınıf // Bir class çıplak BIRAKILMAZ!!
        private IApplicantService _applicantService; // field değişken tanımlama

        public PttManager(IApplicantService applicantService) // Constructor new yapıldığında çalışır.
        {
            _applicantService = applicantService; // dependency injection
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }

    }
}

// Not: Bir iş sınıfı başka bir sınıfı new'lerse bu onun bağımlılığını arttırır. 
// Bu yüzden bu durumda soyutlama yapmak gerekir. 
// Örneğin PttManager PersonManager'ı new'lerse ilerde bir değişim gerektiğinde direnç gösterir.(değişiklik yapmak zorlaşır)
// Bu yüzden PersonManager'ı new'lemek yerine onun soyutlamasını yani interface'ini new'lemek gerekir. (dependency injection)

// Not: Dependency injection: Bir sınıfın başka bir sınıfın nesnesini 
// kullanabilmesi için onun referansını bir şekilde alabilmesi.

// Not: Interface'ler çağrıldığında implemente edilen class'ın referansını tutabilirler.

// NOT!!!! THE REASON WE USE INTERFACE IS TO MAKE OUR CODE MORE FLEXIBLE AND REUSABLE.
// The method GiveMask is implemented in the PttManager class 
// because it is specific to the functionality of the PttManager class. 
// The interface IApplicantService defines the contract that the PttManager
//  class must implement, but it does not provide the implementation details of the GiveMask method. 
// Each class that implements the interface can have its own unique implementation 
// of the methods defined in the interface.