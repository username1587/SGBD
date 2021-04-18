using System.Collections.Generic;
using WindowsFormsApp1.models;

namespace WindowsFormsApp1.Repository
{
    public interface IRepoAngajat
    {
        List<Angajat> getAllAngajatiOfRestaurant(Restaurant restaurant);

        void update(Angajat updatedAngajat);
        
        void add(Angajat newAngajat);

        void remove(Angajat AngajatToRemove);
    }
}