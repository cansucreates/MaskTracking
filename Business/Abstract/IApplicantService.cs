using Entities.Concrete;

namespace Business.Abstract
{
public interface IApplicantService // metodun imzaları burada
{
        void ApplyForMask(Person person);

        List<Person> GetList() ;

        bool CheckPerson(Person person);

}
}
// Not: Interface'ler belli method imzalarını barındırırlar. 
// Birbirinin alternatifi olan sistemlerin farklı implementasyonlarını yapmalarını sağlar.