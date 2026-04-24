using DesignPatterns.Repository;
using DesignPatterns_MVC.Models.ViewModels;

namespace DesignPatterns_MVC.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
