using System.Collections.Generic;
using WindowsFormsApp1.models;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Service
{
    public class Service : IService
    {
        private IRepoAngajat _repoAngajat;
        private IRepoRestaurant _repoRestaurant;

        public Service(IRepoAngajat repoAngajat, IRepoRestaurant repoRestaurant)
        {
            _repoAngajat = repoAngajat;
            _repoRestaurant = repoRestaurant;
        }

        public void getAllRestaurants()
        {
            _repoRestaurant.getAll();
        }

        public void getAllAngajatiOfRestaurant(Restaurant restaurant)
        {
            _repoAngajat.getAllAngajatiOfRestaurant(restaurant);
        }

        public void addAngajat(Angajat angajat)
        {
            _repoAngajat.add(angajat);
        }

        public void deleteAngajat(Angajat angajat)
        {
            _repoAngajat.remove(angajat);

        }

        public void updateAngajat(Angajat angajat)
        {
            _repoAngajat.update(angajat);

        }
    }
}